using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace LuoEasyPrint
{
	// Token: 0x0200000B RID: 11
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class PivotTableDetail : Form
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00002592 File Offset: 0x00000792
		public PivotTableDetail()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000BF78 File Offset: 0x0000A178
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000025A0 File Offset: 0x000007A0
		internal virtual ToolStrip ToolStrip1
		{
			get
			{
				return this._ToolStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStrip1 = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000BF90 File Offset: 0x0000A190
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
		internal virtual ToolStripButton ToolStripButton1
		{
			get
			{
				return this._ToolStripButton1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton1_Click);
				if (this._ToolStripButton1 != null)
				{
					this._ToolStripButton1.Click -= value2;
				}
				this._ToolStripButton1 = value;
				if (this._ToolStripButton1 != null)
				{
					this._ToolStripButton1.Click += value2;
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000C00C File Offset: 0x0000A20C
		internal virtual ToolStripButton ToolStripButton2
		{
			get
			{
				return this._ToolStripButton2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton2_Click);
				if (this._ToolStripButton2 != null)
				{
					this._ToolStripButton2.Click -= value2;
				}
				this._ToolStripButton2 = value;
				if (this._ToolStripButton2 != null)
				{
					this._ToolStripButton2.Click += value2;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000C058 File Offset: 0x0000A258
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000025A9 File Offset: 0x000007A9
		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			get
			{
				return this._ToolStripSeparator1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000C070 File Offset: 0x0000A270
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000C088 File Offset: 0x0000A288
		internal virtual ToolStripButton ToolStripButton4
		{
			get
			{
				return this._ToolStripButton4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton4_Click);
				if (this._ToolStripButton4 != null)
				{
					this._ToolStripButton4.Click -= value2;
				}
				this._ToolStripButton4 = value;
				if (this._ToolStripButton4 != null)
				{
					this._ToolStripButton4.Click += value2;
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000025B2 File Offset: 0x000007B2
		internal virtual ToolStripSeparator ToolStripSeparator2
		{
			get
			{
				return this._ToolStripSeparator2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator2 = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0000C104 File Offset: 0x0000A304
		internal virtual ToolStripButton ToolStripButton3
		{
			get
			{
				return this._ToolStripButton3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton3_Click);
				if (this._ToolStripButton3 != null)
				{
					this._ToolStripButton3.Click -= value2;
				}
				this._ToolStripButton3 = value;
				if (this._ToolStripButton3 != null)
				{
					this._ToolStripButton3.Click += value2;
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000C150 File Offset: 0x0000A350
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000C168 File Offset: 0x0000A368
		internal virtual MulHeaderDataGridView d1
		{
			get
			{
				return this._d1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewRowPostPaintEventHandler value2 = new DataGridViewRowPostPaintEventHandler(this.d1_RowPostPaint);
				if (this._d1 != null)
				{
					this._d1.RowPostPaint -= value2;
				}
				this._d1 = value;
				if (this._d1 != null)
				{
					this._d1.RowPostPaint += value2;
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000025BB File Offset: 0x000007BB
		internal virtual ContextMenuStrip ContextMenuStrip1
		{
			get
			{
				return this._ContextMenuStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip1 = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000C1CC File Offset: 0x0000A3CC
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		internal virtual ToolStripMenuItem ToolStripMenuItem_0
		{
			get
			{
				return this.toolStripMenuItem_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_0_Click);
				if (this.toolStripMenuItem_0 != null)
				{
					this.toolStripMenuItem_0.Click -= value2;
				}
				this.toolStripMenuItem_0 = value;
				if (this.toolStripMenuItem_0 != null)
				{
					this.toolStripMenuItem_0.Click += value2;
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000C230 File Offset: 0x0000A430
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000C248 File Offset: 0x0000A448
		internal virtual ToolStripMenuItem ToolStripMenuItem_1
		{
			get
			{
				return this.toolStripMenuItem_1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_1_Click);
				if (this.toolStripMenuItem_1 != null)
				{
					this.toolStripMenuItem_1.Click -= value2;
				}
				this.toolStripMenuItem_1 = value;
				if (this.toolStripMenuItem_1 != null)
				{
					this.toolStripMenuItem_1.Click += value2;
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000C294 File Offset: 0x0000A494
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000025C4 File Offset: 0x000007C4
		internal virtual ToolStripSeparator ToolStripSeparator3
		{
			get
			{
				return this._ToolStripSeparator3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator3 = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000C2AC File Offset: 0x0000A4AC
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000025CD File Offset: 0x000007CD
		internal virtual ToolStripDropDownButton ToolStripDropDownButton1
		{
			get
			{
				return this._ToolStripDropDownButton1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripDropDownButton1 = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000C2C4 File Offset: 0x0000A4C4
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000C2DC File Offset: 0x0000A4DC
		internal virtual ToolStripMenuItem ToolStripMenuItem_2
		{
			get
			{
				return this.toolStripMenuItem_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_2_Click);
				if (this.toolStripMenuItem_2 != null)
				{
					this.toolStripMenuItem_2.Click -= value2;
				}
				this.toolStripMenuItem_2 = value;
				if (this.toolStripMenuItem_2 != null)
				{
					this.toolStripMenuItem_2.Click += value2;
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000C328 File Offset: 0x0000A528
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000C340 File Offset: 0x0000A540
		internal virtual ToolStripMenuItem ToolStripMenuItem_3
		{
			get
			{
				return this.toolStripMenuItem_3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_3_Click);
				if (this.toolStripMenuItem_3 != null)
				{
					this.toolStripMenuItem_3.Click -= value2;
				}
				this.toolStripMenuItem_3 = value;
				if (this.toolStripMenuItem_3 != null)
				{
					this.toolStripMenuItem_3.Click += value2;
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000C38C File Offset: 0x0000A58C
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		internal virtual ToolStripMenuItem ToolStripMenuItem_4
		{
			get
			{
				return this.toolStripMenuItem_4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_4_Click);
				if (this.toolStripMenuItem_4 != null)
				{
					this.toolStripMenuItem_4.Click -= value2;
				}
				this.toolStripMenuItem_4 = value;
				if (this.toolStripMenuItem_4 != null)
				{
					this.toolStripMenuItem_4.Click += value2;
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000C408 File Offset: 0x0000A608
		internal virtual ToolStripMenuItem ToolStripMenuItem_5
		{
			get
			{
				return this.toolStripMenuItem_5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem_5_Click);
				if (this.toolStripMenuItem_5 != null)
				{
					this.toolStripMenuItem_5.Click -= value2;
				}
				this.toolStripMenuItem_5 = value;
				if (this.toolStripMenuItem_5 != null)
				{
					this.toolStripMenuItem_5.Click += value2;
				}
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000C454 File Offset: 0x0000A654
		private void ToolStripButton1_Click(object sender, EventArgs e)
		{
			if (!(this.d1.RowCount <= 0 | this.d1.ColumnCount <= 0))
			{
				DGVprint dgvprint = new DGVprint();
				dgvprint.MainTitle = this.Text;
				dgvprint.Print(this.d1, true, this.d1.ColHeaderTreeView);
				dgvprint.Dispose();
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000C4B8 File Offset: 0x0000A6B8
		private void ToolStripButton2_Click(object sender, EventArgs e)
		{
			if (!(this.d1.RowCount <= 0 | this.d1.ColumnCount <= 0))
			{
				ExportDataGridView exportDGV = new ExportDataGridView();
				exportDGV.Title = this.Text;
				exportDGV.OpenFile = true;
				exportDGV.ExportDGV(this.d1);
				exportDGV.Dispose();
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000025D6 File Offset: 0x000007D6
		private void ToolStripButton3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000C518 File Offset: 0x0000A718
		private void ToolStripButton4_Click(object sender, EventArgs e)
		{
			PivotDGV pivotDGV = new PivotDGV();
			pivotDGV.Start(this.d1);
			pivotDGV.Dispose();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000025DE File Offset: 0x000007DE
		private void ToolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			this.CopyDGVToCLipBoard(this.d1);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000C540 File Offset: 0x0000A740
		private void CopyDGVToCLipBoard(DataGridView dgv)
		{
			if (dgv.RowCount > 0)
			{
				try
				{
					Clipboard.SetDataObject(RuntimeHelpers.GetObjectValue(dgv.GetClipboardContent().GetData(DataFormats.Text)));
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000025EC File Offset: 0x000007EC
		private void ToolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			this.SumDGVSelection(this.d1);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000C590 File Offset: 0x0000A790
		private void SumDGVSelection(DataGridView mydgv)
		{
			checked
			{
				if (mydgv.SelectedCells.Count <= 0)
				{
					Interaction.MsgBox("当前没有任何选中的内容", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					decimal num = 0m;
					int num2 = 0;
					int num3 = mydgv.SelectedCells.Count - 1;
					for (int i = num2; i <= num3; i++)
					{
						try
						{
							string text = Convert.ToString(Operators.ConcatenateObject(mydgv.SelectedCells[i].Value, ""));
							if (Versioned.IsNumeric(text))
							{
								num = decimal.Add(num, Convert.ToDecimal(text));
							}
						}
						catch (Exception ex)
						{
						}
					}
					Interaction.MsgBox("选中内容求和的结果是：" + Strings.Format(num, "#,###,###,###,###.##"), MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000C65C File Offset: 0x0000A85C
		private void d1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			Color color = this.d1.RowHeadersDefaultCellStyle.ForeColor;
			if (this.d1.Rows[e.RowIndex].Selected)
			{
				color = this.d1.RowHeadersDefaultCellStyle.SelectionForeColor;
			}
			else
			{
				color = this.d1.RowHeadersDefaultCellStyle.ForeColor;
			}
			SolidBrush brush = new SolidBrush(color);
			StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			checked
			{
				Rectangle r = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.d1.RowHeadersWidth - 4, e.RowBounds.Height);
				e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, r, stringFormat);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000025FA File Offset: 0x000007FA
		private void ToolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			this.d1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002608 File Offset: 0x00000808
		private void ToolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			this.d1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002616 File Offset: 0x00000816
		private void ToolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			this.d1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002624 File Offset: 0x00000824
		private void ToolStripMenuItem_5_Click(object sender, EventArgs e)
		{
			this.d1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
		}

		// Token: 0x04000035 RID: 53
		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		// Token: 0x04000036 RID: 54
		[AccessedThroughProperty("ToolStripButton1")]
		private ToolStripButton _ToolStripButton1;

		// Token: 0x04000037 RID: 55
		[AccessedThroughProperty("ToolStripButton2")]
		private ToolStripButton _ToolStripButton2;

		// Token: 0x04000038 RID: 56
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04000039 RID: 57
		[AccessedThroughProperty("ToolStripButton4")]
		private ToolStripButton _ToolStripButton4;

		// Token: 0x0400003A RID: 58
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x0400003B RID: 59
		[AccessedThroughProperty("ToolStripButton3")]
		private ToolStripButton _ToolStripButton3;

		// Token: 0x0400003C RID: 60
		[AccessedThroughProperty("d1")]
		private MulHeaderDataGridView _d1;

		// Token: 0x0400003D RID: 61
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x0400003E RID: 62
		[AccessedThroughProperty("复制选中内容ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x0400003F RID: 63
		[AccessedThroughProperty("选中内容求和ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04000040 RID: 64
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x04000041 RID: 65
		[AccessedThroughProperty("ToolStripDropDownButton1")]
		private ToolStripDropDownButton _ToolStripDropDownButton1;

		// Token: 0x04000042 RID: 66
		[AccessedThroughProperty("自动调整表格列宽包括列标题ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04000043 RID: 67
		[AccessedThroughProperty("自动调整表格列宽不包括列标题ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x04000044 RID: 68
		[AccessedThroughProperty("自动调整表格ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04000045 RID: 69
		[AccessedThroughProperty("自动调整表格行高不包括列标题ToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_5;
	}
}
