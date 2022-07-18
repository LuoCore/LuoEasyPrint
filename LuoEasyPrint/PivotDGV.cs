using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000008 RID: 8
	[ToolboxBitmap(typeof(PivotDGV), "Chartlet.bmp")]
	[Description("可对给定的DataGridView的数据进行任意汇总，类似Excel的透视表")]
	[Guid("3B435384-5900-49BC-8305-4C7011A4DE8D")]
	public class PivotDGV : Component, objsafe.IObjectSafety
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000024CC File Offset: 0x000006CC
		[DebuggerNonUserCode]
		public PivotDGV(IContainer container) : this()
		{
			if (container != null)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000024DE File Offset: 0x000006DE
		[DebuggerNonUserCode]
		public PivotDGV()
		{
			this.myaddtotalrow = true;
			this.mytitle = "数据汇总";
			this.InitializeComponent();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000B3C4 File Offset: 0x000095C4
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
				if (this.myXaxis != null)
				{
					this.myXaxis = null;
				}
				if (this.myYaxis != null)
				{
					this.myYaxis = null;
				}
				if (this.myZaxis != null)
				{
					this.myZaxis = null;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000024FE File Offset: 0x000006FE
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000B430 File Offset: 0x00009630
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000250B File Offset: 0x0000070B
		public string Title
		{
			get
			{
				return this.mytitle;
			}
			set
			{
				this.mytitle = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000B448 File Offset: 0x00009648
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002514 File Offset: 0x00000714
		public bool AddTotalRow
		{
			get
			{
				return this.myaddtotalrow;
			}
			set
			{
				this.myaddtotalrow = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000B45C File Offset: 0x0000965C
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000251D File Offset: 0x0000071D
		public string[] Xaxis
		{
			get
			{
				string[] result;
				if (this.myXaxis == null)
				{
					result = null;
				}
				else
				{
					result = (string[])this.myXaxis.Clone();
				}
				return result;
			}
			set
			{
				if (value == null)
				{
					this.myXaxis = null;
				}
				else
				{
					this.myXaxis = (string[])value.Clone();
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000B488 File Offset: 0x00009688
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000253C File Offset: 0x0000073C
		public string[] Yaxis
		{
			get
			{
				string[] result;
				if (this.myYaxis == null)
				{
					result = null;
				}
				else
				{
					result = (string[])this.myYaxis.Clone();
				}
				return result;
			}
			set
			{
				if (value == null)
				{
					this.myYaxis = null;
				}
				else
				{
					this.myYaxis = (string[])value.Clone();
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000B4B4 File Offset: 0x000096B4
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000255B File Offset: 0x0000075B
		public PivotDGV.SumColumn[] Zaxis
		{
			get
			{
				PivotDGV.SumColumn[] result;
				if (this.myZaxis == null)
				{
					result = null;
				}
				else
				{
					result = (PivotDGV.SumColumn[])this.myZaxis.Clone();
				}
				return result;
			}
			set
			{
				if (value == null)
				{
					this.myZaxis = null;
				}
				else
				{
					this.myZaxis = (PivotDGV.SumColumn[])value.Clone();
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000257A File Offset: 0x0000077A
		public void Start(DataGridView dgv)
		{
			this.Start(dgv, "");
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000B4E0 File Offset: 0x000096E0
		public void Start(DataGridView dgv, string windowtitle)
		{
			checked
			{
				if (dgv != null)
				{
					PivotTableView pivotTableView = new PivotTableView();
					if (this.myXaxis != null)
					{
						pivotTableView.myXaxis = (string[])this.myXaxis.Clone();
					}
					else
					{
						pivotTableView.myXaxis = null;
					}
					if (this.myYaxis != null)
					{
						pivotTableView.myYaxis = (string[])this.myYaxis.Clone();
					}
					else
					{
						pivotTableView.myYaxis = null;
					}
					if (this.myZaxis != null)
					{
						int num = this.myZaxis.Length;
						pivotTableView.myZaxis = new string[num - 1 + 1];
						pivotTableView.myzalign = new StringAlignment[num - 1 + 1];
						pivotTableView.myzformat = new string[num - 1 + 1];
						pivotTableView.myztitle = new string[num - 1 + 1];
						pivotTableView.myzvaluetype = new string[num - 1 + 1];
						int num2 = 0;
						int num3 = num - 1;
						for (int i = num2; i <= num3; i++)
						{
							pivotTableView.myZaxis[i] = this.myZaxis[i].columnname;
							pivotTableView.myztitle[i] = this.myZaxis[i].columntitle;
							string align = this.myZaxis[i].align;
							if (String.Compare(align, "0", false) == 0)
							{
								pivotTableView.myzalign[i] = StringAlignment.Near;
							}
							else if (String.Compare(align, "1", false) == 0)
							{
								pivotTableView.myzalign[i] = StringAlignment.Center;
							}
							else
							{
								pivotTableView.myzalign[i] = StringAlignment.Far;
							}
							pivotTableView.myzformat[i] = this.myZaxis[i].format;
							switch (this.myZaxis[i].type)
							{
							case PivotDGV.SumType.COUNT:
								pivotTableView.myzvaluetype[i] = "计数";
								break;
							case PivotDGV.SumType.AVERAGE:
								pivotTableView.myzvaluetype[i] = "平均值";
								break;
							case PivotDGV.SumType.MAXVALUE:
								pivotTableView.myzvaluetype[i] = "最大值";
								break;
							case PivotDGV.SumType.MINVALUE:
								pivotTableView.myzvaluetype[i] = "最小值";
								break;
							default:
								pivotTableView.myzvaluetype[i] = "求和";
								break;
							}
						}
					}
					else
					{
						pivotTableView.myZaxis = null;
						pivotTableView.myzalign = null;
						pivotTableView.myzformat = null;
						pivotTableView.myztitle = null;
						pivotTableView.myzvaluetype = null;
					}
					pivotTableView.myaddtotalrow = this.myaddtotalrow;
					pivotTableView.sourcedgv = dgv;
					if (String.Compare(this.mytitle, "", false) != 0)
					{
						pivotTableView.Text = this.mytitle;
					}
					int num4 = 0;
					int num5 = dgv.ColumnCount - 1;
					for (int j = num4; j <= num5; j++)
					{
						int num6 = j + 1;
						int num7 = dgv.ColumnCount - 1;
						for (int k = num6; k <= num7; k++)
						{
							if (String.Compare(dgv.Columns[j].Name, dgv.Columns[k].Name, false) == 0)
							{
								dgv.Columns[k].Name = "第" + Convert.ToString(k) + "列P";
							}
						}
					}
					pivotTableView.ShowDialog();
					pivotTableView.Dispose();
				}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002588 File Offset: 0x00000788
		public void GetInterfaceSafetyOptions(ref Guid riid, ref int supportedOptions, ref int enabledOptions)
		{
			supportedOptions = 3;
			enabledOptions = 3;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002590 File Offset: 0x00000790
		public void SetInterfaceSafetyOptions(ref Guid iid, int dwOptionSetMask, int dwEnabledOptions)
		{
		}

		// Token: 0x04000023 RID: 35
		private IContainer components;

		// Token: 0x04000024 RID: 36
		private string[] myXaxis;

		// Token: 0x04000025 RID: 37
		private string[] myYaxis;

		// Token: 0x04000026 RID: 38
		private PivotDGV.SumColumn[] myZaxis;

		// Token: 0x04000027 RID: 39
		private bool myaddtotalrow;

		// Token: 0x04000028 RID: 40
		private string mytitle;

		// Token: 0x02000009 RID: 9
		public enum SumType
		{
			// Token: 0x0400002A RID: 42
			SUM,
			// Token: 0x0400002B RID: 43
			COUNT,
			// Token: 0x0400002C RID: 44
			AVERAGE,
			// Token: 0x0400002D RID: 45
			MAXVALUE,
			// Token: 0x0400002E RID: 46
			MINVALUE
		}

		// Token: 0x0200000A RID: 10
		public struct SumColumn
		{
			// Token: 0x0400002F RID: 47
			public string columnname;

			// Token: 0x04000030 RID: 48
			public string align;

			// Token: 0x04000031 RID: 49
			public PivotDGV.SumType type;

			// Token: 0x04000032 RID: 50
			public string format;

			// Token: 0x04000033 RID: 51
			public string columntitle;
		}
	}
}
