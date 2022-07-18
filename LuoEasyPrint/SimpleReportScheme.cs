using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x02000073 RID: 115
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class SimpleReportScheme
	{
		// Token: 0x06000ED4 RID: 3796 RVA: 0x000780F4 File Offset: 0x000762F4
		public SimpleReportScheme(string rawschemetext)
		{
			this.myEnableChange = true;
			this.myEnableDel = true;
			this.myschemecontent = "";
			this.myschemename = "";
			this.myisChanged = false;
			this.SP = "\u0001\u0003\u0005";
			this.ParaseRawScheme(rawschemetext);
			this.myisChanged = false;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0007814C File Offset: 0x0007634C
		public SimpleReportScheme(string theschemename, DataGridView dgv, string maintitle)
		{
			this.myEnableChange = true;
			this.myEnableDel = true;
			this.myschemecontent = "";
			this.myschemename = "";
			this.myisChanged = false;
			this.SP = "\u0001\u0003\u0005";
			SimpleReportSet simpleReportSet = new SimpleReportSet();
			simpleReportSet.dgvtoprint = dgv;
			this.myschemename = theschemename;
			simpleReportSet.Visible = false;
			simpleReportSet.LoaDDefaultValues();
			simpleReportSet.maintitle.Text = maintitle;
			simpleReportSet.MyLoadDGVDefaultSettings(dgv);
			this.myEnableChange = true;
			this.myschemecontent = simpleReportSet.SaveFa();
			this.myisChanged = true;
			simpleReportSet.Dispose();
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x000781EC File Offset: 0x000763EC
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x00005DE8 File Offset: 0x00003FE8
		public bool EnableChange
		{
			get
			{
				return this.myEnableChange;
			}
			set
			{
				this.myEnableChange = value;
				this.myisChanged = true;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x00078200 File Offset: 0x00076400
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x00005DF8 File Offset: 0x00003FF8
		public bool EnableDel
		{
			get
			{
				return this.myEnableChange;
			}
			set
			{
				this.myEnableDel = value;
				this.myisChanged = true;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00078214 File Offset: 0x00076414
		public bool IsChanged
		{
			get
			{
				return this.myisChanged;
			}
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00078228 File Offset: 0x00076428
		public string GetRawSchemeText()
		{
			string str = this.myschemename;
			str += this.SP;
			if (this.myEnableChange)
			{
				str += "1";
			}
			else
			{
				str += "0";
			}
			if (this.myEnableDel)
			{
				str = str + this.SP + "1";
			}
			else
			{
				str = str + this.SP + "0";
			}
			return str + this.SP + this.myschemecontent;
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x000782B8 File Offset: 0x000764B8
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x00005E08 File Offset: 0x00004008
		public string SchemeContent
		{
			get
			{
				return this.myschemecontent;
			}
			set
			{
				this.myschemecontent = value;
				this.myisChanged = true;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x000782D0 File Offset: 0x000764D0
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x00005E18 File Offset: 0x00004018
		public string SchemeName
		{
			get
			{
				return this.myschemename;
			}
			set
			{
				if (String.Compare(value, "", false) != 0)
				{
					this.myschemename = value;
					this.myisChanged = true;
				}
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x000782E8 File Offset: 0x000764E8
		private bool ParaseRawScheme(string ss)
		{
			this.myschemename = "";
			this.myschemecontent = "";
			this.myEnableChange = true;
			bool result;
			if (String.Compare(ss, "", false) == 0)
			{
				result = false;
			}
			else
			{
				string[] array = Strings.Split(ss, this.SP, -1, CompareMethod.Binary);
				try
				{
					this.myschemename = array[0];
					if (String.Compare(array[1], "1", false) == 0)
					{
						this.myEnableChange = true;
					}
					else
					{
						this.myEnableChange = false;
					}
					if (String.Compare(array[2], "1", false) == 0)
					{
						this.myEnableDel = true;
					}
					else
					{
						this.myEnableDel = false;
					}
					this.myschemecontent = array[3];
				}
				catch (Exception ex)
				{
					return false;
				}
				finally
				{
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0400077B RID: 1915
		private bool myEnableChange;

		// Token: 0x0400077C RID: 1916
		private bool myEnableDel;

		// Token: 0x0400077D RID: 1917
		private string myschemecontent;

		// Token: 0x0400077E RID: 1918
		private string myschemename;

		// Token: 0x0400077F RID: 1919
		private bool myisChanged;

		// Token: 0x04000780 RID: 1920
		private string SP;
	}
}
