using Microsoft.VisualBasic.CompilerServices;
using System.Xml;

namespace LuoEasyPrint
{
    // Token: 0x020000B2 RID: 178
    public sealed class XmlGoldPrinterElementFactory
    {
        // Token: 0x0600176E RID: 5998 RVA: 0x000C6694 File Offset: 0x000C4894
        public static XmlGoldPrinterElement Create(XmlNode elementNode)
        {
            return XmlGoldPrinterElementFactory.CreateXmlDefStandardElement(elementNode);
        }

        // Token: 0x0600176F RID: 5999 RVA: 0x000C66AC File Offset: 0x000C48AC
        public static XmlGoldPrinterElementCollection Create(XmlNode elementNode, bool includeChildren)
        {
            XmlGoldPrinterElementCollection result;
            if (includeChildren)
            {
                result = XmlGoldPrinterElementFactory.CreateXmlDefStandardElementCollection(elementNode);
            }
            else
            {
                XmlGoldPrinterElementCollection xmlGoldPrinterElementCollection = new XmlGoldPrinterElementCollection();
                XmlGoldPrinterElement xmlGoldPrinterElement = XmlGoldPrinterElementFactory.Create(elementNode);
                if (xmlGoldPrinterElement != null)
                {
                    xmlGoldPrinterElementCollection.Add(xmlGoldPrinterElement);
                }
                result = xmlGoldPrinterElementCollection;
            }
            return result;
        }

        // Token: 0x06001770 RID: 6000 RVA: 0x000C66E0 File Offset: 0x000C48E0
        public static XmlGoldPrinterElement Create(XmlNode elementNode, string elementTypeName)
        {
            return XmlGoldPrinterElementFactory.CreateXmlDefStandardElement(elementNode, elementTypeName);
        }

        // Token: 0x06001771 RID: 6001 RVA: 0x000C66F8 File Offset: 0x000C48F8
        private static XmlGoldPrinterElement CreateXmlDefStandardElement(XmlNode elementNode)
        {
            return XmlGoldPrinterElementFactory.CreateXmlDefStandardElement(elementNode, null);
        }

        // Token: 0x06001772 RID: 6002 RVA: 0x000C6710 File Offset: 0x000C4910
        private static XmlGoldPrinterElement CreateXmlDefStandardElement(XmlNode elementNode, string elementTypeName)
        {
            string text;
            if (elementTypeName != null && String.Compare(elementTypeName.Trim(), "", false) != 0)
            {
                text = elementTypeName.Trim().ToLower();
            }
            else
            {
                text = elementNode.Name.Trim().ToLower();
            }
            XmlGoldPrinterElement xmlGoldPrinterElement = null;
            string left = text;
            if (String.Compare(left, "shape", false) == 0)
            {
                xmlGoldPrinterElement = new XmlShape(elementNode);
            }
            else if (String.Compare(left, "dot", false) == 0)
            {
                xmlGoldPrinterElement = new XmlDot(elementNode);
            }
            else if (String.Compare(left, "line", false) == 0)
            {
                xmlGoldPrinterElement = new XmlLine(elementNode);
            }
            else if (String.Compare(left, "rectangle", false) == 0)
            {
                xmlGoldPrinterElement = new XmlRectangle(elementNode);
            }
            else if (String.Compare(left, "circle", false) == 0)
            {
                xmlGoldPrinterElement = new XmlCircle(elementNode);
            }
            else if (String.Compare(left, "ellipse", false) == 0)
            {
                xmlGoldPrinterElement = new XmlEllipse(elementNode);
            }
            else if (String.Compare(left, "textlabel", false) == 0)
            {
                xmlGoldPrinterElement = new XmlTextLabel(elementNode);
            }
            else if (String.Compare(left, "label", false) != 0)
            {
                if (String.Compare(left, "textbox", false) != 0)
                {
                    if (String.Compare(left, "datatext", false) != 0)
                    {
                        if (String.Compare(left, "table", false) == 0)
                        {
                            xmlGoldPrinterElement = new XmlTable(elementNode);
                        }
                    }
                }
            }
            if (xmlGoldPrinterElement != null)
            {
                xmlGoldPrinterElement.Parse();
            }
            return xmlGoldPrinterElement;
        }

        // Token: 0x06001773 RID: 6003 RVA: 0x000C6868 File Offset: 0x000C4A68
        private static XmlGoldPrinterElementCollection CreateXmlDefStandardElementCollection(XmlNode elementsNode)
        {
            XmlGoldPrinterElementCollection xmlGoldPrinterElementCollection = new XmlGoldPrinterElementCollection();
            XmlGoldPrinterElement xmlGoldPrinterElement = XmlGoldPrinterElementFactory.CreateXmlDefStandardElement(elementsNode);
            if (xmlGoldPrinterElement != null)
            {
                xmlGoldPrinterElementCollection.Add(xmlGoldPrinterElement);
                try
                {
                    foreach (object obj in elementsNode)
                    {
                        XmlNode elementNode = (XmlNode)obj;
                        xmlGoldPrinterElement = XmlGoldPrinterElementFactory.CreateXmlDefStandardElement(elementNode);
                        if (xmlGoldPrinterElement != null)
                        {
                            xmlGoldPrinterElementCollection.Add(xmlGoldPrinterElement);
                        }
                    }
                }
                finally
                {

                }
            }
            return xmlGoldPrinterElementCollection;
        }
    }
}
