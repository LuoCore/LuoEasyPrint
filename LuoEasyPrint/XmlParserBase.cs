using System.Xml;

namespace LuoEasyPrint
{
    // Token: 0x020000B8 RID: 184
    public abstract class XmlParserBase : IXmlParser
    {
        // Token: 0x060017CC RID: 6092 RVA: 0x0000868F File Offset: 0x0000688F
        public XmlParserBase()
        {
            this._ReportDesigner = ReportDesigner.GoldPrinter;
        }

        // Token: 0x060017CD RID: 6093 RVA: 0x0000869E File Offset: 0x0000689E
        public XmlParserBase(XmlNode format) : this()
        {
            this._XmlNode = format;
        }

        // Token: 0x060017CE RID: 6094 RVA: 0x000C737C File Offset: 0x000C557C
        public static Color GetColorFrom(string color)
        {
            string text;
            if (color == null)
            {
                text = "";
            }
            else
            {
                text = color.Trim();
            }
            Color result;
            if (String.Compare(text, "", false) != 0 && String.Compare(text.Substring(0, 1), "#", false) == 0 && text.Length == 7)
            {
                if (text.Length < 7)
                {
                    text = text.PadRight(7, '0');
                }
                int red = Convert.ToInt32(text.Substring(1, 2), 16);
                int green = Convert.ToInt32(text.Substring(3, 2), 16);
                int blue = Convert.ToInt32(text.Substring(5, 2), 16);
                result = Color.FromArgb(red, green, blue);
            }
            else if (text.IndexOf(',') > -1)
            {
                string[] array = text.Split(new char[]
                {
                    ','
                });
                int red2 = 0;
                int green2 = 0;
                int blue2 = 0;
                if (array.Length > 0 && String.Compare(array[0], "", false) != 0)
                {
                    red2 = XmlParserBase.GetValidColorValue(Convert.ToInt32(array[0]));
                }
                if (array.Length > 1 && String.Compare(array[1], "", false) != 0)
                {
                    green2 = XmlParserBase.GetValidColorValue(Convert.ToInt32(array[1]));
                }
                if (array.Length > 2 && String.Compare(array[2], "", false) != 0)
                {
                    blue2 = XmlParserBase.GetValidColorValue(Convert.ToInt32(array[2]));
                }
                result = Color.FromArgb(red2, green2, blue2);
            }
            else
            {
                result = Color.FromName(text);
            }
            return result;
        }

        // Token: 0x060017CF RID: 6095 RVA: 0x000C74E4 File Offset: 0x000C56E4
        private static int GetValidColorValue(int colorValue)
        {
            int num = colorValue;
            int result;
            if (colorValue < 0)
            {
                result = 0;
            }
            else
            {
                if (colorValue > 255)
                {
                    num = 255;
                }
                result = num;
            }
            return result;
        }

        // Token: 0x060017D0 RID: 6096 RVA: 0x000C750C File Offset: 0x000C570C
        protected XmlAttribute GetXmlNodeAttributeByName(string attributeName)
        {
            if (this._XmlNode != null)
            {
                try
                {
                    foreach (object obj in this._XmlNode.Attributes)
                    {
                        XmlAttribute xmlAttribute = (XmlAttribute)obj;
                        if (String.Compare(xmlAttribute.Name.ToUpper(), attributeName.ToUpper(), false) == 0)
                        {
                            return xmlAttribute;
                        }
                    }
                }
                finally
                {

                }
            }
            return null;
        }

        // Token: 0x060017D1 RID: 6097 RVA: 0x000C7594 File Offset: 0x000C5794
        protected virtual string GetXmlNodeAttributeValue(string attributeName)
        {
            XmlAttribute xmlNodeAttributeByName = this.GetXmlNodeAttributeByName(attributeName);
            string result;
            if (xmlNodeAttributeByName == null)
            {
                result = "";
            }
            else
            {
                result = xmlNodeAttributeByName.Value;
            }
            return result;
        }

        // Token: 0x060017D2 RID: 6098 RVA: 0x000C75BC File Offset: 0x000C57BC
        protected XmlNode GetXmlNodeChildNodeByName(string childNodeName)
        {
            if (this._XmlNode != null)
            {
                try
                {
                    foreach (object obj in this._XmlNode.ChildNodes)
                    {
                        XmlNode xmlNode = (XmlNode)obj;
                        if (String.Compare(xmlNode.Name.ToUpper(), childNodeName.ToUpper(), false) == 0)
                        {
                            return xmlNode;
                        }
                    }
                }
                finally
                {

                }
            }
            return null;
        }

        // Token: 0x060017D3 RID: 6099 RVA: 0x000C7644 File Offset: 0x000C5844
        public static XmlNode GetXmlNodeChildNodeByName(XmlNode parentNode, string childNodeName)
        {
            if (parentNode != null)
            {
                try
                {
                    foreach (object obj in parentNode.ChildNodes)
                    {
                        XmlNode xmlNode = (XmlNode)obj;
                        if (String.Compare(xmlNode.Name.ToUpper(), childNodeName.ToUpper(), false) == 0)
                        {
                            return xmlNode;
                        }
                    }
                }
                finally
                {

                }
            }
            return null;
        }

        // Token: 0x060017D4 RID: 6100 RVA: 0x000C76C0 File Offset: 0x000C58C0
        protected virtual string GetXmlNodeChildNodeValue(string childNodeName)
        {
            XmlNode xmlNodeChildNodeByName = this.GetXmlNodeChildNodeByName(childNodeName);
            string result;
            if (xmlNodeChildNodeByName == null)
            {
                result = "";
            }
            else if (xmlNodeChildNodeByName.ChildNodes.Count > 1)
            {
                result = "";
            }
            else
            {
                result = xmlNodeChildNodeByName.InnerText;
            }
            return result;
        }

        // Token: 0x060017D5 RID: 6101 RVA: 0x000C7700 File Offset: 0x000C5900
        protected virtual string GetXmlNodeChildNodeValue(string sonNodeName, string sonChildNodeName)
        {
            XmlNode xmlNodeChildNodeByName = this.GetXmlNodeChildNodeByName(sonNodeName);
            string result;
            if (xmlNodeChildNodeByName == null)
            {
                result = "";
            }
            else
            {
                XmlNode xmlNodeChildNodeByName2 = XmlParserBase.GetXmlNodeChildNodeByName(xmlNodeChildNodeByName, sonChildNodeName);
                if (xmlNodeChildNodeByName2 == null)
                {
                    result = "";
                }
                else if (xmlNodeChildNodeByName2.ChildNodes.Count > 1)
                {
                    result = "";
                }
                else
                {
                    result = xmlNodeChildNodeByName2.InnerText;
                }
            }
            return result;
        }

        // Token: 0x060017D6 RID: 6102 RVA: 0x000C7754 File Offset: 0x000C5954
        public static string GetXmlNodeChildNodeValue(XmlNode parentNode, string childNodeName)
        {
            XmlNode xmlNodeChildNodeByName = XmlParserBase.GetXmlNodeChildNodeByName(parentNode, childNodeName);
            string result;
            if (xmlNodeChildNodeByName == null)
            {
                result = "";
            }
            else if (xmlNodeChildNodeByName.ChildNodes.Count > 1)
            {
                result = "";
            }
            else if (xmlNodeChildNodeByName.ChildNodes.Count > 1)
            {
                result = "";
            }
            else
            {
                result = xmlNodeChildNodeByName.InnerText;
            }
            return result;
        }

        // Token: 0x060017D7 RID: 6103 RVA: 0x000C77A8 File Offset: 0x000C59A8
        protected virtual string GetXmlNodeChildNodeValue(XmlNode parentNode, string sonNodeName, string sonChildNodeName)
        {
            XmlNode xmlNodeChildNodeByName = XmlParserBase.GetXmlNodeChildNodeByName(parentNode, sonNodeName);
            string result;
            if (xmlNodeChildNodeByName == null)
            {
                result = "";
            }
            else
            {
                XmlNode xmlNodeChildNodeByName2 = XmlParserBase.GetXmlNodeChildNodeByName(xmlNodeChildNodeByName, sonChildNodeName);
                if (xmlNodeChildNodeByName2 == null)
                {
                    result = "";
                }
                else if (xmlNodeChildNodeByName2.ChildNodes.Count > 1)
                {
                    result = "";
                }
                else
                {
                    result = xmlNodeChildNodeByName2.InnerText;
                }
            }
            return result;
        }

        // Token: 0x060017D8 RID: 6104 RVA: 0x000C77FC File Offset: 0x000C59FC
        protected string GetXmlNodeCompatibleAttributeValue(ref string existValue, string attributeName)
        {
            string result;
            if (existValue != null && String.Compare(existValue, "", false) != 0)
            {
                result = "";
            }
            else
            {
                existValue = this.GetXmlNodeAttributeValue(attributeName);
                result = existValue;
            }
            return result;
        }

        // Token: 0x060017D9 RID: 6105 RVA: 0x000C7834 File Offset: 0x000C5A34
        private XmlAttribute GetXmlNodeStyleAttribute()
        {
            return this.GetXmlNodeAttributeByName("style");
        }

        // Token: 0x060017DA RID: 6106 RVA: 0x000C7850 File Offset: 0x000C5A50
        protected string GetXmlNodeStyleAttributeValue()
        {
            XmlAttribute xmlNodeStyleAttribute = this.GetXmlNodeStyleAttribute();
            string result;
            if (xmlNodeStyleAttribute == null)
            {
                result = "";
            }
            else
            {
                result = xmlNodeStyleAttribute.Value;
            }
            return result;
        }

        // Token: 0x060017DB RID: 6107 RVA: 0x000C7878 File Offset: 0x000C5A78
        protected string GetXmlNodeStyleAttributeValue(string attributeName)
        {
            string xmlNodeStyleAttributeValue = this.GetXmlNodeStyleAttributeValue();
            return this.GetXmlNodeStyleAttributeValue(xmlNodeStyleAttributeValue, attributeName);
        }

        // Token: 0x060017DC RID: 6108 RVA: 0x000C7898 File Offset: 0x000C5A98
        protected string GetXmlNodeStyleAttributeValue(string styleText, string attributeName)
        {
            checked
            {
                if (String.Compare(styleText, "", false) != 0)
                {
                    string[] array = styleText.Split(new char[]
                    {
                        ';'
                    });
                    int num = 0;
                    int num2 = array.Length - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        if (array[i].Trim().ToLower().IndexOf(attributeName.ToLower()) > -1)
                        {
                            return array[i].Trim().Substring(array[i].Trim().IndexOf(':') + 1).Trim();
                        }
                    }
                }
                return "";
            }
        }

        // Token: 0x060017DD RID: 6109 RVA: 0x000C792C File Offset: 0x000C5B2C
        protected XmlNode GetXmlNodeStyleChildNode()
        {
            return this.GetXmlNodeChildNodeByName("Style");
        }

        // Token: 0x060017DE RID: 6110 RVA: 0x000C7948 File Offset: 0x000C5B48
        protected string GetXmlNodeStyleChildNodeValue(string styleSonNodeName)
        {
            XmlNode xmlNodeStyleChildNode = this.GetXmlNodeStyleChildNode();
            string result;
            if (xmlNodeStyleChildNode == null)
            {
                result = "";
            }
            else
            {
                XmlNode xmlNodeChildNodeByName = XmlParserBase.GetXmlNodeChildNodeByName(xmlNodeStyleChildNode, styleSonNodeName);
                if (xmlNodeChildNodeByName == null)
                {
                    result = "";
                }
                else
                {
                    result = xmlNodeChildNodeByName.InnerText;
                }
            }
            return result;
        }

        // Token: 0x060017DF RID: 6111 RVA: 0x000C7984 File Offset: 0x000C5B84
        protected virtual string GetXmlNodeText()
        {
            return this._XmlNode.InnerText;
        }

        // Token: 0x060017E0 RID: 6112
        public abstract IXmlParser Parse();

        // Token: 0x060017E1 RID: 6113 RVA: 0x000C79A0 File Offset: 0x000C5BA0
        public static XmlNode SelectRootNode(string xmlFileName)
        {
            XmlDocument xmlDocument = new XmlDocument();
            try
            {
                xmlDocument.Load(xmlFileName);
            }
            catch (Exception ex)
            {
                return null;
            }
            return xmlDocument.DocumentElement;
        }

        // Token: 0x060017E2 RID: 6114 RVA: 0x000C79E4 File Offset: 0x000C5BE4
        public static XmlNode SelectSingleNodeByAttribute(string xmlFileName, string nodeName, string attributeName, string attributeValue)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlFileName);
            XmlNode documentElement = xmlDocument.DocumentElement;
            return documentElement.SelectSingleNode(string.Concat(new string[]
            {
                "descendant::",
                nodeName,
                "[@",
                attributeName,
                "='",
                attributeValue,
                "']"
            }));
        }

        // Token: 0x060017E3 RID: 6115 RVA: 0x000C7A48 File Offset: 0x000C5C48
        public static XmlNode SelectSingleNodeByNodeName(string xmlFileName, string nodeName)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode result;
            try
            {
                xmlDocument.Load(xmlFileName);
                XmlNode documentElement = xmlDocument.DocumentElement;
                result = documentElement.SelectSingleNode("descendant::" + nodeName);
            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }

        // Token: 0x060017E4 RID: 6116 RVA: 0x000C7AA0 File Offset: 0x000C5CA0
        public void SetAttributeText(string attributeName, string attributeText)
        {
            XmlAttribute xmlNodeAttributeByName = this.GetXmlNodeAttributeByName(attributeName);
            if (xmlNodeAttributeByName != null)
            {
                xmlNodeAttributeByName.InnerText = attributeText;
            }
            else
            {
                XmlAttribute xmlAttribute = this._XmlNode.OwnerDocument.CreateAttribute(attributeName);
                xmlAttribute.InnerText = attributeText;
                this._XmlNode.Attributes.Append(xmlAttribute);
            }
        }

        // Token: 0x17000767 RID: 1895
        // (get) Token: 0x060017E5 RID: 6117 RVA: 0x000C7AEC File Offset: 0x000C5CEC
        // (set) Token: 0x060017E6 RID: 6118 RVA: 0x000086AD File Offset: 0x000068AD
        public ReportDesigner ReportDesigner
        {
            get
            {
                return this._ReportDesigner;
            }
            set
            {
                this._ReportDesigner = value;
            }
        }

        // Token: 0x17000768 RID: 1896
        // (get) Token: 0x060017E7 RID: 6119 RVA: 0x000C7B04 File Offset: 0x000C5D04
        // (set) Token: 0x060017E8 RID: 6120 RVA: 0x000086B6 File Offset: 0x000068B6
        public XmlNode XmlNode
        {
            get
            {
                return this._XmlNode;
            }
            set
            {
                this._XmlNode = value;
            }
        }

        // Token: 0x04000B3D RID: 2877
        protected ReportDesigner _ReportDesigner;

        // Token: 0x04000B3E RID: 2878
        protected XmlNode _XmlNode;
    }
}
