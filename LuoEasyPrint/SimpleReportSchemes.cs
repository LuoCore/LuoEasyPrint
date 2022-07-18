using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections;
using System.ComponentModel;


namespace LuoEasyPrint
{
    // Token: 0x02000074 RID: 116
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class SimpleReportSchemes : IDisposable
    {
        // Token: 0x170004EB RID: 1259
        // (get) Token: 0x06000EE1 RID: 3809 RVA: 0x000783BC File Offset: 0x000765BC
        public bool IsChaneged
        {
            get
            {
                return this.myischanged;
            }
        }

        // Token: 0x06000EE2 RID: 3810 RVA: 0x000783D0 File Offset: 0x000765D0
        public SimpleReportSchemes(string ss)
        {
            this.SP = "\u0002\u0004\u0006";
            this.myenabledadd = true;
            this.myenableedit = true;
            this.myenableddel = true;
            this.myischanged = false;
            this.myscheme = new Hashtable();
            this.ParamScheme(ss);
            this.myischanged = false;
        }

        // Token: 0x06000EE3 RID: 3811 RVA: 0x00078424 File Offset: 0x00076624
        public SimpleReportSchemes(string thename, DataGridView dgv, string maintitle)
        {
            this.SP = "\u0002\u0004\u0006";
            this.myenabledadd = true;
            this.myenableedit = true;
            this.myenableddel = true;
            this.myischanged = false;
            SimpleReportScheme thescheme = new SimpleReportScheme(thename, dgv, maintitle);
            this.myscheme = new Hashtable();
            this.AddScheme(thescheme);
        }

        // Token: 0x06000EE4 RID: 3812 RVA: 0x00005E37 File Offset: 0x00004037
        public void AddScheme(SimpleReportScheme thescheme)
        {
            this.myscheme.Add(thescheme.SchemeName, thescheme.GetRawSchemeText());
            this.myischanged = true;
        }

        // Token: 0x06000EE5 RID: 3813 RVA: 0x0007847C File Offset: 0x0007667C
        public void AddScheme(string rawschemetext)
        {
            SimpleReportScheme thescheme = new SimpleReportScheme(rawschemetext);
            this.AddScheme(thescheme);
        }

        // Token: 0x06000EE6 RID: 3814 RVA: 0x0007849C File Offset: 0x0007669C
        public bool DeleteScheme(string thename)
        {
            bool result;
            if (this.myscheme.ContainsKey(thename))
            {
                this.myscheme.Remove(thename);
                this.myischanged = true;
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        // Token: 0x06000EE7 RID: 3815 RVA: 0x000784D4 File Offset: 0x000766D4
        public bool ChangeScheme(string thename, string rawschemetext)
        {
            bool result;
            if (!this.IsExists(thename))
            {
                result = false;
            }
            else
            {
                SimpleReportScheme simpleReportScheme = new SimpleReportScheme(rawschemetext);
                if (String.Compare(simpleReportScheme.SchemeName, thename, false) != 0)
                {
                    simpleReportScheme.SchemeName = thename;
                    rawschemetext = simpleReportScheme.GetRawSchemeText();
                }
                this.myscheme[thename] = rawschemetext;
                this.myischanged = true;
                result = true;
            }
            return result;
        }

        // Token: 0x06000EE8 RID: 3816 RVA: 0x00078530 File Offset: 0x00076730
        public bool RenameSchemeName(string oldschemename, string newschemename)
        {
            bool result;
            if (this.myscheme == null)
            {
                result = false;
            }
            else if (!this.IsExists(oldschemename))
            {
                result = false;
            }
            else if (this.IsExists(newschemename))
            {
                Interaction.MsgBox("指定的新方案名称【" + newschemename + "】已经存在，重命名失败", MsgBoxStyle.OkOnly, "提示信息");
                result = false;
            }
            else
            {
                SimpleReportScheme simpleReportScheme = new SimpleReportScheme(this.GetSchemeRawText(oldschemename));
                simpleReportScheme.SchemeName = newschemename;
                this.myscheme.Remove(oldschemename);
                this.myscheme.Add(newschemename, simpleReportScheme.GetRawSchemeText());
                if (String.Compare(this.DefaultScheme, oldschemename, false) == 0)
                {
                    this.DefaultScheme = newschemename;
                }
                result = true;
            }
            return result;
        }

        // Token: 0x06000EE9 RID: 3817 RVA: 0x000785D0 File Offset: 0x000767D0
        public string Save()
        {
            string text = this.myDefaultScheme;
            text += this.SP;
            if (this.myenabledadd)
            {
                text += "1";
            }
            else
            {
                text += "0";
            }
            if (this.myenableedit)
            {
                text = text + this.SP + "1";
            }
            else
            {
                text = text + this.SP + "0";
            }
            if (this.myenableddel)
            {
                text = text + this.SP + "1";
            }
            else
            {
                text = text + this.SP + "0";
            }
            string result;
            if (this.myscheme == null)
            {
                text = text + this.SP + "";
                result = text;
            }
            else if (this.myscheme.Count <= 0)
            {
                text = text + this.SP + "";
                result = text;
            }
            else
            {
                foreach (object obj in this.myscheme)
                {
                    DictionaryEntry dictionaryEntry2 = new DictionaryEntry();
                    DictionaryEntry dictionaryEntry = (obj != null) ? ((DictionaryEntry)obj) : dictionaryEntry2;
                    text = text + this.SP + Convert.ToString(dictionaryEntry.Value);
                }
                result = text;
            }
            return result;
        }

        // Token: 0x06000EEA RID: 3818 RVA: 0x000786FC File Offset: 0x000768FC
        public string[] GetSchemeName()
        {
            checked
            {
                string[] result;
                if (this.myscheme == null)
                {
                    result = null;
                }
                else if (this.myscheme.Count <= 0)
                {
                    result = null;
                }
                else
                {
                    string[] array = null;
                    int num = 0;
                    foreach (object obj in this.myscheme)
                    {
                        DictionaryEntry dictionaryEntry2 = new DictionaryEntry();
                        DictionaryEntry dictionaryEntry = (obj != null) ? ((DictionaryEntry)obj) : dictionaryEntry2;
                        array = (string[])Utils.CopyArray((Array)array, new string[num + 1]);
                        array[num] = Convert.ToString(dictionaryEntry.Key);
                        num++;
                    }
                    result = array;
                }
                return result;
            }
        }

        // Token: 0x06000EEB RID: 3819 RVA: 0x0007878C File Offset: 0x0007698C
        public string GetSchemeRawText(string thename)
        {
            string result;
            if (this.myscheme == null)
            {
                result = "";
            }
            else if (this.myscheme.Count <= 0)
            {
                result = "";
            }
            else if (!this.myscheme.ContainsKey(thename))
            {
                result = "";
            }
            else
            {
                result = Convert.ToString(this.myscheme[thename]);
            }
            return result;
        }

        // Token: 0x170004EC RID: 1260
        // (get) Token: 0x06000EEC RID: 3820 RVA: 0x000787E8 File Offset: 0x000769E8
        // (set) Token: 0x06000EED RID: 3821 RVA: 0x00005E57 File Offset: 0x00004057
        public bool EnableAdd
        {
            get
            {
                return this.myenabledadd;
            }
            set
            {
                this.myenabledadd = value;
                this.myischanged = true;
            }
        }

        // Token: 0x170004ED RID: 1261
        // (get) Token: 0x06000EEE RID: 3822 RVA: 0x000787FC File Offset: 0x000769FC
        // (set) Token: 0x06000EEF RID: 3823 RVA: 0x00005E67 File Offset: 0x00004067
        public bool EnableEdit
        {
            get
            {
                return this.myenableedit;
            }
            set
            {
                this.myenableedit = value;
                this.myischanged = true;
            }
        }

        // Token: 0x170004EE RID: 1262
        // (get) Token: 0x06000EF0 RID: 3824 RVA: 0x00078810 File Offset: 0x00076A10
        // (set) Token: 0x06000EF1 RID: 3825 RVA: 0x00005E77 File Offset: 0x00004077
        public bool EnableDel
        {
            get
            {
                return this.myenableddel;
            }
            set
            {
                this.myenableddel = value;
                this.myischanged = true;
            }
        }

        // Token: 0x170004EF RID: 1263
        // (get) Token: 0x06000EF2 RID: 3826 RVA: 0x00078824 File Offset: 0x00076A24
        // (set) Token: 0x06000EF3 RID: 3827 RVA: 0x00005E87 File Offset: 0x00004087
        public string DefaultScheme
        {
            get
            {
                return this.myDefaultScheme;
            }
            set
            {
                if (this.myscheme != null && this.myscheme.ContainsKey(value))
                {
                    this.myDefaultScheme = value;
                    this.myischanged = true;
                }
            }
        }

        // Token: 0x06000EF4 RID: 3828 RVA: 0x0007883C File Offset: 0x00076A3C
        public bool IsExists(string schemename)
        {
            return this.myscheme != null && this.myscheme.ContainsKey(schemename);
        }

        // Token: 0x06000EF5 RID: 3829 RVA: 0x0007886C File Offset: 0x00076A6C
        public int GetSchemeCount()
        {
            int result;
            if (this.myscheme == null)
            {
                result = 0;
            }
            else
            {
                result = this.myscheme.Count;
            }
            return result;
        }

        // Token: 0x06000EF6 RID: 3830 RVA: 0x00078894 File Offset: 0x00076A94
        private void ParamScheme(string ss)
        {
            checked
            {
                if (String.Compare(ss, "", false) != 0)
                {
                    this.myscheme.Clear();
                    string[] array = Strings.Split(ss, this.SP, -1, CompareMethod.Binary);
                    if (String.Compare(array[1], "1", false) == 0)
                    {
                        this.myenabledadd = true;
                    }
                    else
                    {
                        this.myenabledadd = false;
                    }
                    if (String.Compare(array[2], "1", false) == 0)
                    {
                        this.myenableedit = true;
                    }
                    else
                    {
                        this.myenableedit = false;
                    }
                    if (String.Compare(array[3], "1", false) == 0)
                    {
                        this.myenableddel = true;
                    }
                    else
                    {
                        this.myenableddel = false;
                    }
                    int num = 4;
                    int num2 = array.Length - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        SimpleReportScheme simpleReportScheme = new SimpleReportScheme(array[i]);
                        this.myscheme.Add(simpleReportScheme.SchemeName, array[i]);
                    }
                    this.DefaultScheme = array[0];
                }
            }
        }

        // Token: 0x06000EF7 RID: 3831 RVA: 0x00078970 File Offset: 0x00076B70
        public static string[] GetAllSchemeNames(string schemefile)
        {
            string[] result;
            if (!MyProject.Computer.FileSystem.FileExists(schemefile))
            {
                result = null;
            }
            else
            {
                string ss = MyProject.Computer.FileSystem.ReadAllText(schemefile);
                SimpleReportSchemes simpleReportSchemes = new SimpleReportSchemes(ss);
                string[] schemeName = simpleReportSchemes.GetSchemeName();
                simpleReportSchemes.Dispose();
                result = schemeName;
            }
            return result;
        }

        // Token: 0x06000EF8 RID: 3832 RVA: 0x000789C0 File Offset: 0x00076BC0
        public static string GetDefaultSchemeName(string schemefile)
        {
            string result;
            if (!MyProject.Computer.FileSystem.FileExists(schemefile))
            {
                result = "";
            }
            else
            {
                string ss = MyProject.Computer.FileSystem.ReadAllText(schemefile);
                SimpleReportSchemes simpleReportSchemes = new SimpleReportSchemes(ss);
                string defaultScheme = simpleReportSchemes.DefaultScheme;
                simpleReportSchemes.Dispose();
                result = defaultScheme;
            }
            return result;
        }

        // Token: 0x06000EF9 RID: 3833 RVA: 0x00005EAD File Offset: 0x000040AD
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue && disposing && this.myscheme != null)
            {
                this.myscheme.Clear();
                this.myscheme = null;
            }
            this.disposedValue = true;
        }

        // Token: 0x06000EFA RID: 3834 RVA: 0x00005EDB File Offset: 0x000040DB
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Token: 0x04000781 RID: 1921
        private Hashtable myscheme;

        // Token: 0x04000782 RID: 1922
        private string SP;

        // Token: 0x04000783 RID: 1923
        private string myDefaultScheme;

        // Token: 0x04000784 RID: 1924
        private bool myenabledadd;

        // Token: 0x04000785 RID: 1925
        private bool myenableedit;

        // Token: 0x04000786 RID: 1926
        private bool myenableddel;

        // Token: 0x04000787 RID: 1927
        private bool myischanged;

        // Token: 0x04000788 RID: 1928
        private bool disposedValue;
    }
}
