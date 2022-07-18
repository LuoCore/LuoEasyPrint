using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace LuoEasyPrint
{
	// Token: 0x02000060 RID: 96
	[ComVisible(true)]
	public sealed class PrintPreviewControl : Control
	{
		// Token: 0x06000D7B RID: 3451 RVA: 0x0006C7A4 File Offset: 0x0006A9A4
		public PrintPreviewControl()
		{
			this.isneedpaint = true;
			this._havewheel = SystemInformation.MouseWheelPresent;
			this._havewheel = false;
			this._position = new Point(0, 0);
			this._virtualSize = new Size(1, 1);
			this._rows = 1;
			this._columns = 1;
			this._autoZoom = true;
			this._isshowprocessdialog = true;
			this.imageSize = Size.Empty;
			this.screendpi = Point.Empty;
			this._zoom = 0.3;
			this.ResetBackColor();
			this.ResetForeColor();
			Size size = new Size(100, 100);
			base.Size = size;
			base.SetStyle(ControlStyles.ResizeRedraw, false);
			base.SetStyle(ControlStyles.Opaque | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0006C860 File Offset: 0x0006AA60
		private int AdjustScroll(Message m, int pos, int maxPos)
		{
			checked
			{
				int result=0;
				switch (Win32.LOWORD(m.WParam))
				{
				case 0:
					if (pos <= 5)
					{
						pos = 0;
						result = 0;
					}
					else
					{
						pos -= 5;
						result = pos;
					}
					break;
				case 1:
					if (pos >= maxPos - 5)
					{
						pos = maxPos;
						result = pos;
					}
					else
					{
						pos += 5;
						result = pos;
					}
					break;
				case 2:
					if (pos <= 100)
					{
						pos = 0;
						result = 0;
					}
					else
					{
						pos -= 100;
						result = pos;
					}
					break;
				case 3:
					if (pos >= maxPos - 100)
					{
						pos = maxPos;
						result = pos;
					}
					else
					{
						pos += 100;
						result = pos;
					}
					break;
				case 4:
				case 5:
					pos = Win32.HIWORD(m.WParam);
					result = pos;
					break;
				default:
					result = pos;
					break;
				}
				return result;
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0006C904 File Offset: 0x0006AB04
		private void CalculatePageInfo()
		{
			if (!this.pageInfoCalcPending)
			{
				this.pageInfoCalcPending = true;
				try
				{
					if (this.pageInfo == null)
					{
						try
						{
							this.ComputePreview();
						}
						catch (Exception ex)
						{
							this.exceptionPrinting = true;
							throw;
						}
						finally
						{
							base.Invalidate();
						}
					}
				}
				finally
				{
					this.pageInfoCalcPending = false;
				}
			}
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0006C978 File Offset: 0x0006AB78
		private void ComputeLayout()
		{
			this.layoutOk = true;
			checked
			{
				if (this.pageInfo.Length == 0)
				{
					base.ClientSize = base.Size;
				}
				else
				{
					Graphics graphics = base.CreateGraphics();
					IntPtr hdc = graphics.GetHdc();
					HandleRef hDC = new HandleRef(graphics, hdc);
					int deviceCaps = Win32.GetDeviceCaps(hDC, 88);
					HandleRef hDC2 = new HandleRef(graphics, hdc);
					this.screendpi = new Point(deviceCaps, Win32.GetDeviceCaps(hDC2, 90));
					graphics.ReleaseHdcInternal(hdc);
					graphics.Dispose();
					Size physicalSize = this.pageInfo[this.StartPage].PhysicalSize;
					Point point = new Point(base.Size);
					Size size = new Size(PrintPreviewControl.PixelsToPhysical(point, this.screendpi));
					if (this.AutoZoom)
					{
						double val = (double)(size.Width - 10 * (this.Columns + 1)) / (double)(this.Columns * physicalSize.Width);
						double val2 = (double)(size.Height - 10 * (this.Rows + 1)) / (double)(this.Rows * physicalSize.Height);
						this.Zoom = Math.Min(val, val2);
					}
					this.imageSize = new Size((int)Math.Round(unchecked(this.Zoom * (double)physicalSize.Width)), (int)Math.Round(unchecked(this.Zoom * (double)physicalSize.Height)));
					int x = this.imageSize.Width * this.Columns + 10 * (this.Columns + 1);
					int y = this.imageSize.Height * this.Rows + 10 * (this.Rows + 1);
					point = new Point(x, y);
					Size virtualSizeNoInvalidate = new Size(PrintPreviewControl.PhysicalToPixels(point, this.screendpi));
					this.SetVirtualSizeNoInvalidate(virtualSizeNoInvalidate);
				}
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0006CB24 File Offset: 0x0006AD24
		private void ComputePreview()
		{
			if (this.Document == null)
			{
				this.pageInfo = new PreviewPageInfo[0];
			}
			else
			{
				PrintController printController = this.Document.PrintController;
				PreviewPrintController previewPrintController = new PreviewPrintController();
				previewPrintController.UseAntiAlias = this.UseAntiAlias;
				if (this.IsShowprocessDialog && base.Visible)
				{
					this.Document.PrintController = new PrintControllerWithStatusDialog(previewPrintController, "正在生成打印预览，请稍侯……");
				}
				else
				{
					this.Document.PrintController = previewPrintController;
				}
				this.isneedpaint = false;
				this.Document.Print();
				this.isneedpaint = true;
				this.pageInfo = previewPrintController.GetPreviewPageInfo();
				this.Document.PrintController = printController;
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x000058D1 File Offset: 0x00003AD1
		private void InvalidateLayout()
		{
			this.layoutOk = false;
			base.Invalidate();
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x000058E0 File Offset: 0x00003AE0
		public void InvalidatePreview()
		{
			this.pageInfo = null;
			if (!base.Visible)
			{
				this.ComputePreview();
			}
			else
			{
				this.ComputePreview();
				this.InvalidateLayout();
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0006CBD0 File Offset: 0x0006ADD0
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			base.OnMouseWheel(e);
			checked
			{
				if (this.pageInfo.Length != 0 && this._havewheel)
				{
					float num = (float)((double)(e.Delta * SystemInformation.MouseWheelScrollLines) / 20.0);
					Point position = this.Position;
					int num2 = position.Y;
					int num3 = Math.Min(base.Height, this.VirtualSize.Height);
					if (num < 0f)
					{
						if (num2 >= num3 - 177)
						{
							if (this.StartPage < this.pageInfo.Length - 1)
							{
								this.StartPage++;
								position.Y = 0;
								this.Position = position;
							}
							else
							{
								num2 = num3;
								position.Y = num2;
								this.Position = position;
							}
						}
						else
						{
							num2 += (int)Math.Round((double)Math.Abs(num));
							position.Y = num2;
							this.Position = position;
						}
					}
					else
					{
						num2 = position.Y;
						if (num2 <= 5)
						{
							if (this.StartPage > 0)
							{
								this.StartPage--;
								num2 = num3;
								position.Y = num2;
								this.Position = position;
							}
							else
							{
								position.Y = 0;
								this.Position = position;
							}
						}
						else
						{
							num2 -= (int)Math.Round((double)num);
							position.Y = num2;
							this.Position = position;
						}
					}
				}
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0006CD24 File Offset: 0x0006AF24
		protected override void OnPaint(PaintEventArgs pevent)
		{
			checked
			{
				if (this.isneedpaint)
				{
					Brush brush = new SolidBrush(this.BackColor);
					if (this.pageInfo != null)
					{
						if (this.pageInfo.Length != 0)
						{
							if (!this.layoutOk)
							{
								this.ComputeLayout();
							}
							Point position = new Point(base.Size);
							Size size = new Size(PrintPreviewControl.PixelsToPhysical(position, this.screendpi));
							Point point = new Point(this.VirtualSize);
							Point point2 = new Point((int)Math.Round(Math.Max(0.0, (double)(base.Size.Width - point.X) / 2.0)), (int)Math.Round(Math.Max(0.0, (double)(base.Size.Height - point.Y) / 2.0)));
							int x = point2.X;
							position = this.Position;
							point2.X = x - position.X;
							int y = point2.Y;
							position = this.Position;
							point2.Y = y - position.Y;
							int num = PrintPreviewControl.PhysicalToPixels(10, this.screendpi.X);
							int num2 = PrintPreviewControl.PhysicalToPixels(10, this.screendpi.Y);
							Region clip = pevent.Graphics.Clip;
							Rectangle[] array = new Rectangle[this.Rows * this.Columns - 1 + 1];
							Point empty = Point.Empty;
							int num3 = 0;
							try
							{
								int num4 = 0;
								int num5 = this.Rows - 1;
								for (int i = num4; i <= num5; i++)
								{
									empty.X = 0;
									empty.Y = num3 * i;
									int num6 = 0;
									int num7 = this.Columns - 1;
									for (int j = num6; j <= num7; j++)
									{
										int num8 = this.StartPage + j + i * this.Columns;
										if (num8 < this.pageInfo.Length)
										{
											Size physicalSize = this.pageInfo[num8].PhysicalSize;
											if (this.AutoZoom)
											{
												double val = (double)(size.Width - 10 * (this.Columns + 1)) / (double)(this.Columns * physicalSize.Width);
												double val2 = (double)(size.Height - 10 * (this.Rows + 1)) / (double)(this.Rows * physicalSize.Height);
												this.Zoom = Math.Min(val, val2);
											}
											this.imageSize = new Size((int)Math.Round(unchecked(this.Zoom * (double)physicalSize.Width)), (int)Math.Round(unchecked(this.Zoom * (double)physicalSize.Height)));
											position = new Point(this.imageSize);
											Point point3 = PrintPreviewControl.PhysicalToPixels(position, this.screendpi);
											int x2 = point2.X + num * (j + 1) + empty.X;
											int y2 = point2.Y + num2 * (i + 1) + empty.Y;
											empty.X += point3.X;
											num3 = Math.Max(num3, point3.Y);
											array[num8 - this.StartPage] = new Rectangle(x2, y2, point3.X, point3.Y);
											pevent.Graphics.ExcludeClip(array[num8 - this.StartPage]);
										}
									}
								}
								pevent.Graphics.FillRectangle(brush, base.ClientRectangle);
							}
							finally
							{
								pevent.Graphics.Clip = clip;
							}
							int num9 = 0;
							int num10 = array.Length - 1;
							for (int k = num9; k <= num10; k++)
							{
								if (k + this.StartPage < this.pageInfo.Length)
								{
									Rectangle rect = array[k];
									pevent.Graphics.DrawRectangle(Pens.Black, rect);
									pevent.Graphics.FillRectangle(new SolidBrush(this.ForeColor), rect);
									rect.Inflate(-1, -1);
									if (this.pageInfo[k + this.StartPage].Image != null)
									{
										pevent.Graphics.DrawImage(this.pageInfo[k + this.StartPage].Image, rect);
									}
									rect.Width--;
									rect.Height--;
									pevent.Graphics.DrawRectangle(Pens.Black, rect);
								}
							}
							goto IL_48C;
						}
					}
					pevent.Graphics.FillRectangle(brush, base.ClientRectangle);
					if (this.pageInfo != null || this.exceptionPrinting)
					{
						StringFormat stringFormat = new StringFormat();
						stringFormat.Alignment = PrintPreviewControl.TranslateAlignment(ContentAlignment.MiddleCenter);
						stringFormat.LineAlignment = PrintPreviewControl.TranslateLineAlignment(ContentAlignment.MiddleCenter);
						SolidBrush solidBrush = new SolidBrush(this.ForeColor);
						try
						{
							if (this.exceptionPrinting)
							{
								pevent.Graphics.DrawString("建立预览页时发生未处理的异常。", this.Font, solidBrush, base.ClientRectangle, stringFormat);
								base.OnPaint(pevent);
							}
							else
							{
								pevent.Graphics.DrawString("文档不包含任何页。", this.Font, solidBrush, base.ClientRectangle, stringFormat);
								base.OnPaint(pevent);
							}
						}
						finally
						{
							solidBrush.Dispose();
							stringFormat.Dispose();
						}
						return;
					}
					base.BeginInvoke(new MethodInvoker(this.CalculatePageInfo));
					IL_48C:
					brush.Dispose();
					brush = null;
				}
			}
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00005905 File Offset: 0x00003B05
		protected override void OnResize(EventArgs e)
		{
			this.InvalidateLayout();
			base.OnResize(e);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0006D298 File Offset: 0x0006B498
		private static Point PhysicalToPixels(Point physical, Point dpi)
		{
			Point result = new Point(PrintPreviewControl.PhysicalToPixels(physical.X, dpi.X), PrintPreviewControl.PhysicalToPixels(physical.Y, dpi.Y));
			return result;
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0006D2D8 File Offset: 0x0006B4D8
		private static Size PhysicalToPixels(Size physicalSize, Point dpi)
		{
			Size result = new Size(PrintPreviewControl.PhysicalToPixels(physicalSize.Width, dpi.X), PrintPreviewControl.PhysicalToPixels(physicalSize.Height, dpi.Y));
			return result;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0006D318 File Offset: 0x0006B518
		private static int PhysicalToPixels(int physicalSize, int dpi)
		{
			return checked((int)Math.Round((double)(physicalSize * dpi) / 100.0));
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0006D33C File Offset: 0x0006B53C
		private static Point PixelsToPhysical(Point pixels, Point dpi)
		{
			Point result = new Point(PrintPreviewControl.PixelsToPhysical(pixels.X, dpi.X), PrintPreviewControl.PixelsToPhysical(pixels.Y, dpi.Y));
			return result;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0006D37C File Offset: 0x0006B57C
		private static Size PixelsToPhysical(Size pixels, Point dpi)
		{
			Size result = new Size(PrintPreviewControl.PixelsToPhysical(pixels.Width, dpi.X), PrintPreviewControl.PixelsToPhysical(pixels.Height, dpi.Y));
			return result;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0006D3BC File Offset: 0x0006B5BC
		private static int PixelsToPhysical(int pixels, int dpi)
		{
			return checked((int)Math.Round((double)(pixels * 100) / (double)dpi));
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0006D3DC File Offset: 0x0006B5DC
		public override void ResetBackColor()
		{
			this.BackColor = SystemColors.AppWorkspace;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0006D3F4 File Offset: 0x0006B5F4
		public override void ResetForeColor()
		{
			this.ForeColor = Color.White;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0006D40C File Offset: 0x0006B60C
		private void SetPositionNoInvalidate(Point value)
		{
			Point position = this._position;
			this._position = value;
			checked
			{
				this._position.X = Math.Min(this._position.X, this.VirtualSize.Width - base.Width);
				this._position.Y = Math.Min(this._position.Y, this.VirtualSize.Height - base.Height);
				if (this._position.X < 0)
				{
					this._position.X = 0;
				}
				if (this._position.Y < 0)
				{
					this._position.Y = 0;
				}
				Rectangle clientRectangle = base.ClientRectangle;
				Win32.RECT rect = Win32.RECT.FromXYWH(clientRectangle.X, clientRectangle.Y, clientRectangle.Width, clientRectangle.Height);
				HandleRef handleRef = new HandleRef(this, base.Handle);
				HandleRef hWnd = handleRef;
				int nXAmount = position.X - this.Position.X;
				int nYAmount = position.Y - this.Position.Y;
				Win32.RECT rect2 = rect;
				Win32.RECT rect3 = rect;
				Win32.ScrollWindow(hWnd, nXAmount, nYAmount, ref rect2, ref rect3);
				handleRef = new HandleRef(this, base.Handle);
				Win32.SetScrollPos(handleRef, 0, this.Position.X, true);
				handleRef = new HandleRef(this, base.Handle);
				Win32.SetScrollPos(handleRef, 1, this.Position.Y, true);
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0006D580 File Offset: 0x0006B780
		private void SetVirtualSizeNoInvalidate(Size value)
		{
			this._virtualSize = value;
			this.SetPositionNoInvalidate(this._position);
			Win32.SCROLLINFO scrollinfo = new Win32.SCROLLINFO();
			scrollinfo.fMask = 3;
			scrollinfo.nMin = 0;
			checked
			{
				scrollinfo.nMax = Math.Max(base.Height, this._virtualSize.Height) - 1;
				scrollinfo.nPage = base.Height;
				HandleRef hWnd = new HandleRef(this, base.Handle);
				Win32.SetScrollInfo(hWnd, 1, scrollinfo, true);
				scrollinfo.fMask = 3;
				scrollinfo.nMin = 0;
				scrollinfo.nMax = Math.Max(base.Width, this._virtualSize.Width) - 1;
				scrollinfo.nPage = base.Width;
				hWnd = new HandleRef(this, base.Handle);
				Win32.SetScrollInfo(hWnd, 0, scrollinfo, true);
			}
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0006D648 File Offset: 0x0006B848
		private static StringAlignment TranslateAlignment(ContentAlignment align)
		{
			StringAlignment result;
			if ((align & PrintPreviewControl.anyRight) != (ContentAlignment)0)
			{
				result = StringAlignment.Far;
			}
			else if ((align & PrintPreviewControl.anyCenter) != (ContentAlignment)0)
			{
				result = StringAlignment.Center;
			}
			else
			{
				result = StringAlignment.Near;
			}
			return result;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0006D674 File Offset: 0x0006B874
		private static StringAlignment TranslateLineAlignment(ContentAlignment align)
		{
			StringAlignment result;
			if ((align & PrintPreviewControl.anyBottom) != (ContentAlignment)0)
			{
				result = StringAlignment.Far;
			}
			else if ((align & PrintPreviewControl.anyMiddle) != (ContentAlignment)0)
			{
				result = StringAlignment.Center;
			}
			else
			{
				result = StringAlignment.Near;
			}
			return result;
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0006D6A0 File Offset: 0x0006B8A0
		private void WmHScroll(ref Message m)
		{
			if (m.LParam != IntPtr.Zero)
			{
				Message message = m;
				base.WndProc(ref message);
			}
			else
			{
				Point position = this._position;
				int x = position.X;
				int maxPos = Math.Max(base.Width, this.VirtualSize.Width);
				position.X = this.AdjustScroll(m, x, maxPos);
				this.Position = position;
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0006D718 File Offset: 0x0006B918
		private void WmKeyDown(ref Message msg)
		{
			Keys keys = (Keys)((int)msg.WParam | (int)Control.ModifierKeys);
			Point position = this.Position;
			checked
			{
				switch (keys & Keys.KeyCode)
				{
				case Keys.Prior:
					if ((keys & Keys.Modifiers) == Keys.Control)
					{
						int num = position.X;
						if (num <= 100)
						{
							num = 0;
						}
						else
						{
							num -= 100;
						}
						position.X = num;
						this.Position = position;
					}
					else if (this.StartPage > 0)
					{
						this.StartPage--;
					}
					break;
				case Keys.Next:
					if ((keys & Keys.Modifiers) == Keys.Control)
					{
						int num = position.X;
						int num2 = Math.Max(base.Width, this.VirtualSize.Width);
						if (num >= num2 - 100)
						{
							num = num2;
						}
						else
						{
							num += 100;
						}
						position.X = num;
						this.Position = position;
					}
					else if (this.StartPage < this.pageInfo.Length)
					{
						this.StartPage++;
					}
					break;
				case Keys.End:
					if ((keys & Keys.Modifiers) == Keys.Control)
					{
						this.StartPage = this.pageInfo.Length;
					}
					break;
				case Keys.Home:
					if ((keys & Keys.Modifiers) == Keys.Control)
					{
						this.StartPage = 0;
					}
					break;
				case Keys.Left:
				{
					int num = position.X;
					if (num > 5)
					{
						num -= 5;
					}
					else
					{
						num = 0;
					}
					position.X = num;
					this.Position = position;
					break;
				}
				case Keys.Up:
				{
					int num = position.Y;
					if (num > 5)
					{
						num -= 5;
					}
					else
					{
						num = 0;
					}
					position.Y = num;
					this.Position = position;
					break;
				}
				case Keys.Right:
				{
					int num = position.X;
					int num2 = Math.Max(base.Width, this.VirtualSize.Width);
					if (num < num2 - 5)
					{
						num += 5;
					}
					else
					{
						num = num2;
					}
					position.X = num;
					this.Position = position;
					break;
				}
				case Keys.Down:
				{
					int num = position.Y;
					int num2 = Math.Max(base.Height, this.VirtualSize.Height);
					if (num < num2 - 5)
					{
						num += 5;
					}
					else
					{
						num = num2;
					}
					position.Y = num;
					this.Position = position;
					break;
				}
				}
			}
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0006D95C File Offset: 0x0006BB5C
		private void WmVScroll(ref Message m)
		{
			if (m.LParam != IntPtr.Zero)
			{
				Message message = m;
				base.WndProc(ref message);
			}
			else
			{
				Point position = this._position;
				int y = position.Y;
				int maxPos = Math.Max(base.Height, this._virtualSize.Height);
				position.Y = this.AdjustScroll(m, y, maxPos);
				this.Position = position;
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0006D9D0 File Offset: 0x0006BBD0
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			int msg = m.Msg;
			if (msg == 276)
			{
				this.WmHScroll(ref m);
			}
			else if (msg == 277)
			{
				this.WmVScroll(ref m);
			}
			else if (msg == 256)
			{
				this.WmKeyDown(ref m);
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0006DA1C File Offset: 0x0006BC1C
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x00005914 File Offset: 0x00003B14
		public bool AutoZoom
		{
			get
			{
				return this._autoZoom;
			}
			set
			{
				if (this._autoZoom != value)
				{
					this._autoZoom = value;
					this.InvalidateLayout();
				}
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0006DA30 File Offset: 0x0006BC30
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x0000592C File Offset: 0x00003B2C
		public int Columns
		{
			get
			{
				return this._columns;
			}
			set
			{
				if (value < 1)
				{
					throw new ArgumentOutOfRangeException("Columns", "预览页面列数不能小于1。");
				}
				this._columns = value;
				this.InvalidateLayout();
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0006DA48 File Offset: 0x0006BC48
		protected override CreateParams CreateParams
		{
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.Style |= 1048576;
				createParams.Style |= 2097152;
				return createParams;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x0006DA84 File Offset: 0x0006BC84
		// (set) Token: 0x06000D9B RID: 3483 RVA: 0x0000594F File Offset: 0x00003B4F
		public PrintDocument Document
		{
			get
			{
				return this._document;
			}
			set
			{
				this._document = value;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0006DA9C File Offset: 0x0006BC9C
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x00005958 File Offset: 0x00003B58
		public bool IsShowprocessDialog
		{
			get
			{
				return this._isshowprocessdialog;
			}
			set
			{
				this._isshowprocessdialog = value;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x0006DAB0 File Offset: 0x0006BCB0
		[Browsable(false)]
		public int PageCount
		{
			get
			{
				return this.pageInfo.Length;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0006DAC8 File Offset: 0x0006BCC8
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x00005961 File Offset: 0x00003B61
		private Point Position
		{
			get
			{
				return this._position;
			}
			set
			{
				this.SetPositionNoInvalidate(value);
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0006DAE0 File Offset: 0x0006BCE0
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x0000596A File Offset: 0x00003B6A
		public override RightToLeft RightToLeft
		{
			get
			{
				return base.RightToLeft;
			}
			set
			{
				base.RightToLeft = value;
				this.InvalidatePreview();
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0006DAF8 File Offset: 0x0006BCF8
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x00005979 File Offset: 0x00003B79
		public int Rows
		{
			get
			{
				return this._rows;
			}
			set
			{
				if (value < 1)
				{
					throw new ArgumentOutOfRangeException("Rows", "预览的纵向页数不能小于1。");
				}
				this._rows = value;
				this.InvalidateLayout();
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0006DB10 File Offset: 0x0006BD10
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x0006DB54 File Offset: 0x0006BD54
		public int StartPage
		{
			get
			{
				int val = this._startPage;
				if (this.pageInfo != null)
				{
					val = Math.Min(val, checked(this.pageInfo.Length - this.Rows * this.Columns));
				}
				return Math.Max(val, 0);
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("StartPage", "起始页数不能小于零。");
				}
				int startPage = this.StartPage;
				this._startPage = value;
				if (startPage != this.StartPage)
				{
					this.InvalidateLayout();
				}
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0006DB94 File Offset: 0x0006BD94
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x0000599C File Offset: 0x00003B9C
		public bool UseAntiAlias
		{
			get
			{
				return this.antiAlias;
			}
			set
			{
				this.antiAlias = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x0006DBA8 File Offset: 0x0006BDA8
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x000059A5 File Offset: 0x00003BA5
		private Size VirtualSize
		{
			get
			{
				return this._virtualSize;
			}
			set
			{
				this.SetVirtualSizeNoInvalidate(value);
				base.Invalidate();
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x0006DBC0 File Offset: 0x0006BDC0
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x000059B4 File Offset: 0x00003BB4
		public double Zoom
		{
			get
			{
				return this._zoom;
			}
			set
			{
				if (value <= 0.0)
				{
					throw new ArgumentException("打印预览的显示大小不能小于0");
				}
				this.AutoZoom = false;
				this._zoom = value;
				this.InvalidateLayout();
			}
		}

		// Token: 0x04000669 RID: 1641
		private bool isneedpaint;

		// Token: 0x0400066A RID: 1642
		private bool _havewheel;

		// Token: 0x0400066B RID: 1643
		private bool antiAlias;

		// Token: 0x0400066C RID: 1644
		private static readonly ContentAlignment anyBottom = (ContentAlignment)1792;

		// Token: 0x0400066D RID: 1645
		private static readonly ContentAlignment anyCenter = (ContentAlignment)546;

		// Token: 0x0400066E RID: 1646
		private static readonly ContentAlignment anyMiddle = (ContentAlignment)112;

		// Token: 0x0400066F RID: 1647
		private static readonly ContentAlignment anyRight = (ContentAlignment)1092;

		// Token: 0x04000670 RID: 1648
		private bool _autoZoom;

		// Token: 0x04000671 RID: 1649
		private int _columns;

		// Token: 0x04000672 RID: 1650
		private PrintDocument _document;

		// Token: 0x04000673 RID: 1651
		private bool exceptionPrinting;

		// Token: 0x04000674 RID: 1652
		private Size imageSize;

		// Token: 0x04000675 RID: 1653
		private bool _isshowprocessdialog;

		// Token: 0x04000676 RID: 1654
		private bool layoutOk;

		// Token: 0x04000677 RID: 1655
		private PreviewPageInfo[] pageInfo;

		// Token: 0x04000678 RID: 1656
		private bool pageInfoCalcPending;

		// Token: 0x04000679 RID: 1657
		private Point _position;

		// Token: 0x0400067A RID: 1658
		private int _rows;

		// Token: 0x0400067B RID: 1659
		private Point screendpi;

		// Token: 0x0400067C RID: 1660
		private int _startPage;

		// Token: 0x0400067D RID: 1661
		private Size _virtualSize;

		// Token: 0x0400067E RID: 1662
		private double _zoom;
	}
}
