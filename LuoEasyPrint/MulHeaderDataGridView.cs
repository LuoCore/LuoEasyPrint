using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LuoEasyPrint
{
    // Token: 0x020000D1 RID: 209
    [ToolboxBitmap(typeof(MulHeaderDataGridView), "Table.bmp")]
    [Description("多表头(复杂表头)的DataGridView控件(net2.0)")]
    public class MulHeaderDataGridView : DataGridView
    {
        // Token: 0x060018B9 RID: 6329 RVA: 0x00008A91 File Offset: 0x00006C91
        public MulHeaderDataGridView()
        {
            base.Disposed += this.MulHeaderDataGridView_Disposed;
            this.iNodeLevels = 0;
            this.ColLists = new List<TreeNode>();
            this.hasshowerror = false;
            this._addrownumber = false;
        }

        // Token: 0x170007A8 RID: 1960
        // (get) Token: 0x060018BA RID: 6330 RVA: 0x000CA904 File Offset: 0x000C8B04
        // (set) Token: 0x060018BB RID: 6331 RVA: 0x00008ACC File Offset: 0x00006CCC
        [Description("是否添加行号")]
        public bool AddRowNumber
        {
            get
            {
                return this._addrownumber;
            }
            set
            {
                this._addrownumber = value;
            }
        }

        // Token: 0x170007A9 RID: 1961
        // (get) Token: 0x060018BC RID: 6332 RVA: 0x000CA918 File Offset: 0x000C8B18
        // (set) Token: 0x060018BD RID: 6333 RVA: 0x000CA930 File Offset: 0x000C8B30
        [Description("用于设置多维列标题的树结构")]
        public TreeView ColHeaderTreeView
        {
            get
            {
                return this._ColHeaderTreeView;
            }
            set
            {
                this._ColHeaderTreeView = value;
                this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                try
                {
                    this.myNodeLevels();
                }
                catch (Exception ex)
                {
                }
                this.Refresh();
            }
        }

        // Token: 0x060018BE RID: 6334 RVA: 0x000CA978 File Offset: 0x000C8B78
        public void RefreshMergeSetting()
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.ColumnCount - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        int num3 = 0;
                        int num4 = this.RowCount - 1;
                        for (int j = num3; j <= num4; j++)
                        {
                            string left = Convert.ToString(this.Rows[j].Cells[i].Tag);
                            if (String.Compare(left, "水平合并", false) != 0 & String.Compare(left, "垂直合并", false) != 0 & String.Compare(left, "合并", false) != 0 & String.Compare(left, "不合并", false) != 0 & String.Compare(left, "上合并", false) != 0 & String.Compare(left, "下合并", false) != 0 & String.Compare(left, "左合并", false) != 0 & String.Compare(left, "右合并", false) != 0 & String.Compare(left, "左上合并", false) != 0 & String.Compare(left, "左下合并", false) != 0 & String.Compare(left, "右上合并", false) != 0 & String.Compare(left, "右下合并", false) != 0 & String.Compare(left, "上边合并", false) != 0 & String.Compare(left, "下边合并", false) != 0 & String.Compare(left, "左边合并", false) != 0 & String.Compare(left, "右边合并", false) != 0)
                            {
                                if (String.Compare(Convert.ToString(this.Columns[i].Tag), "合并", false) == 0)
                                {
                                    if (String.Compare(Convert.ToString(this.Rows[j].Tag), "合并", false) == 0)
                                    {
                                        this.Rows[j].Cells[i].Tag = "合并";
                                    }
                                    else
                                    {
                                        this.Rows[j].Cells[i].Tag = "#垂直合并#";
                                    }
                                }
                                else if (String.Compare(Convert.ToString(this.Rows[j].Tag), "合并", false) == 0)
                                {
                                    this.Rows[j].Cells[i].Tag = "#水平合并#";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                this.Invalidate();
            }
        }

        // Token: 0x060018BF RID: 6335 RVA: 0x000CAC1C File Offset: 0x000C8E1C
        private void DrawCell(DataGridViewCellPaintingEventArgs e)
        {
            if (e.CellStyle.Alignment == DataGridViewContentAlignment.NotSet)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            int columnCount = this.ColumnCount;
            checked
            {
                int[] array = new int[columnCount - 1 + 1];
                int[] array2 = new int[columnCount - 1 + 1];
                int num = 0;
                int num2 = columnCount - 1;
                for (int i = num; i <= num2; i++)
                {
                    array2[i] = i;
                    array[i] = this.Columns[i].DisplayIndex;
                }
                Array.Sort<int, int>(array, array2);
                Brush brush = new SolidBrush(this.GridColor);
                int num3 = 1;
                int num4 = 0;
                int num5 = 0;
                int num6 = 0;
                int num7 = 0;
                int num8 = 1;
                float num9 = (float)e.CellBounds.Width;
                float num10 = (float)e.CellBounds.Height;
                int columnIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                string left = Convert.ToString(this.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag);
                int firstcol = 0;
                int firstrow = 0;
                if (String.Compare(left, "垂直合并", false) != 0)
                {
                    if (String.Compare(left, "#垂直合并#", false) != 0)
                    {
                        if (String.Compare(left, "上合并", false) != 0)
                        {
                            if (String.Compare(left, "下合并", false) != 0)
                            {
                                if (String.Compare(left, "水平合并", false) != 0)
                                {
                                    if (String.Compare(left, "#水平合并#", false) != 0)
                                    {
                                        if (String.Compare(left, "左合并", false) != 0)
                                        {
                                            if (String.Compare(left, "右合并", false) != 0)
                                            {
                                                if (String.Compare(left, "合并", false) != 0)
                                                {
                                                    if (String.Compare(left, "左上合并", false) != 0)
                                                    {
                                                        if (String.Compare(left, "左下合并", false) != 0)
                                                        {
                                                            if (String.Compare(left, "右上合并", false) != 0)
                                                            {
                                                                if (String.Compare(left, "右下合并", false) != 0)
                                                                {
                                                                    if (String.Compare(left, "上边合并", false) != 0)
                                                                    {
                                                                        if (String.Compare(left, "下边合并", false) != 0)
                                                                        {
                                                                            if (String.Compare(left, "左边合并", false) != 0)
                                                                            {
                                                                                if (String.Compare(left, "右边合并", false) != 0)
                                                                                {
                                                                                    goto IL_2B8;
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                mymerge.GetHVMergeWidthAndHeight(this, e.ColumnIndex, e.RowIndex, ref num9, ref num10, ref num7, ref num6, ref num4, ref num5, ref firstcol, ref firstrow, ref columnIndex, ref rowIndex);
                                                num8 = num6 + num7 + 1;
                                                num3 = num4 + num5 + 1;
                                                goto IL_2B8;
                                            }
                                        }
                                    }
                                }
                                num9 = (float)((int)Math.Round((double)mymerge.GetHMergeWidth(this, e.ColumnIndex, e.RowIndex, ref num8, ref num6, ref num7, ref firstcol, ref columnIndex, true)));
                                goto IL_2B8;
                            }
                        }
                    }
                }
                num10 = (float)mymerge.GetVMergeHeight(this, e.ColumnIndex, e.RowIndex, ref num3, ref num5, ref num4, ref firstrow, ref rowIndex);
            IL_2B8:
                if (num8 == 1 & num3 == 1)
                {
                    e.Handled = false;
                }
                else
                {
                    Pen pen = new Pen(brush);
                    string left2 = Convert.ToString(this.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag);
                    if (String.Compare(left2, "垂直合并", false) != 0)
                    {
                        if (String.Compare(left2, "#垂直合并#", false) != 0)
                        {
                            if (String.Compare(left2, "上合并", false) != 0)
                            {
                                if (String.Compare(left2, "下合并", false) != 0)
                                {
                                    if (String.Compare(left2, "水平合并", false) != 0)
                                    {
                                        if (String.Compare(left2, "#水平合并#", false) != 0)
                                        {
                                            if (String.Compare(left2, "左合并", false) != 0)
                                            {
                                                if (String.Compare(left2, "右合并", false) != 0)
                                                {
                                                    if (String.Compare(left2, "合并", false) != 0)
                                                    {
                                                        if (String.Compare(left2, "左上合并", false) != 0)
                                                        {
                                                            if (String.Compare(left2, "左下合并", false) != 0)
                                                            {
                                                                if (String.Compare(left2, "右上合并", false) != 0)
                                                                {
                                                                    if (String.Compare(left2, "右下合并", false) != 0)
                                                                    {
                                                                        if (String.Compare(left2, "上边合并", false) != 0)
                                                                        {
                                                                            if (String.Compare(left2, "下边合并", false) != 0)
                                                                            {
                                                                                if (String.Compare(left2, "左边合并", false) != 0)
                                                                                {
                                                                                    if (String.Compare(left2, "右边合并", false) != 0)
                                                                                    {
                                                                                        goto IL_4AC;
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    this.PaintingFont(e, (int)Math.Round((double)num9), (int)Math.Round((double)num10), firstrow, firstcol, rowIndex, columnIndex);
                                                    goto IL_4AC;
                                                }
                                            }
                                        }
                                    }
                                    this.PaintingFont(e, (int)Math.Round((double)num9), (int)Math.Round((double)num10), firstrow, firstcol, rowIndex, columnIndex);
                                    goto IL_4AC;
                                }
                            }
                        }
                    }
                    this.PaintingFont(e, (int)Math.Round((double)num9), (int)Math.Round((double)num10), firstrow, firstcol, rowIndex, columnIndex);
                IL_4AC:
                    if (num5 == 0)
                    {
                        e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    }
                    if (num7 == 0)
                    {
                        e.Graphics.DrawLine(pen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                    }
                    e.Handled = true;
                }
            }
        }

        // Token: 0x060018C0 RID: 6336 RVA: 0x000CB184 File Offset: 0x000C9384
        private void PaintingFont(DataGridViewCellPaintingEventArgs e, int cellwidth, int cellheight, int firstrow, int firstcol, int rowindex, int colindex)
        {
            SolidBrush brush = new SolidBrush(Module1.GetDGVCellForeColor(this.Rows[rowindex].Cells[colindex]));
            StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
            DataGridViewCellStyle dgvcellStyle = Module1.GetDGVCellStyle(this.Rows[rowindex].Cells[colindex]);
            try
            {
                stringFormat.LineAlignment = Module1.GetVAlignment(dgvcellStyle.Alignment, false);
                stringFormat.Alignment = Module1.GetHAlignment(dgvcellStyle.Alignment);
                if (this.Rows[rowindex].Cells[colindex].Style.WrapMode != DataGridViewTriState.True)
                {
                    stringFormat.FormatFlags |= StringFormatFlags.NoWrap;
                }
            }
            catch (Exception ex)
            {
            }
            checked
            {
                float x = (float)(e.CellBounds.X + this.DefaultCellStyle.Padding.Left - firstcol);
                Rectangle cellBounds = e.CellBounds;
                float y = (float)(cellBounds.Y - firstrow + this.DefaultCellStyle.Padding.Top);
                float width = (float)(cellwidth - this.DefaultCellStyle.Padding.Size.Width);
                Size size = this.DefaultCellStyle.Padding.Size;
                RectangleF rectangleF = new RectangleF(x, y, width, (float)(cellheight - size.Height));
                SolidBrush solidBrush = new SolidBrush(Module1.GetDGVCellBackColor(this.Rows[rowindex].Cells[colindex]));
                if (this.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected | this.Rows[e.RowIndex].Selected)
                {
                    solidBrush.Color = e.CellStyle.SelectionBackColor;
                }
                e.Graphics.FillRectangle(solidBrush, e.CellBounds);
                if (this.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    rectangleF.Inflate(0f, -1f);
                    e.Graphics.DrawImage((Image)e.FormattedValue, rectangleF);
                }
                else if (this.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
                {
                    Bitmap bitmap = null;
                    CheckBox checkBox = new CheckBox();
                    Control control = checkBox;
                    size = new Size(14, 14);
                    control.Size = size;
                    checkBox.BackColor = Module1.GetDGVCellBackColor(this.Rows[rowindex].Cells[colindex]);
                    if (String.Compare(Versioned.TypeName(RuntimeHelpers.GetObjectValue(e.FormattedValue)), "Boolean", false) == 0)
                    {
                        if (Convert.ToBoolean(e.FormattedValue))
                        {
                            checkBox.Checked = true;
                        }
                        else
                        {
                            checkBox.Checked = false;
                        }
                    }
                    else
                    {
                        switch (Convert.ToInt32(e.FormattedValue))
                        {
                            case 0:
                                checkBox.Checked = false;
                                break;
                            case 1:
                                checkBox.Checked = true;
                                break;
                            default:
                                checkBox.CheckState = CheckState.Indeterminate;
                                break;
                        }
                    }
                    try
                    {
                        bitmap = new Bitmap((int)Math.Round((double)rectangleF.Width), (int)Math.Round((double)rectangleF.Height));
                        Graphics graphics = Graphics.FromImage(bitmap);
                        Brush brush2 = new SolidBrush(Module1.GetDGVCellBackColor(this.Rows[rowindex].Cells[colindex]));
                        Graphics graphics2 = graphics;
                        Brush brush3 = brush2;
                        cellBounds = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                        graphics2.FillRectangle(brush3, cellBounds);
                        Control control2 = checkBox;
                        Bitmap bitmap2 = bitmap;
                        cellBounds = new Rectangle((int)Math.Round((double)(bitmap.Width - checkBox.Width) / 2.0), (int)Math.Round((double)(bitmap.Height - checkBox.Height) / 2.0), checkBox.Width, checkBox.Height);
                        control2.DrawToBitmap(bitmap2, cellBounds);
                        graphics.Dispose();
                    }
                    catch (Exception ex2)
                    {
                    }
                    rectangleF.Inflate(0f, -1f);
                    e.Graphics.DrawImage(bitmap, rectangleF);
                    bitmap.Dispose();
                    bitmap = null;
                    checkBox.Dispose();
                    checkBox = null;
                }
                else
                {
                    e.Graphics.DrawString(Convert.ToString(e.FormattedValue), Module1.GetDGVCellFont(this.Rows[rowindex].Cells[colindex]), brush, rectangleF, stringFormat);
                }
            }
        }

        // Token: 0x060018C1 RID: 6337 RVA: 0x000CB5F8 File Offset: 0x000C97F8
        private int myGetNodeLevels(TreeNodeCollection tnc)
        {
            checked
            {
                int result;
                if (tnc == null)
                {
                    result = 0;
                }
                else
                {
                    try
                    {
                        foreach (object obj in tnc)
                        {
                            TreeNode treeNode = (TreeNode)obj;
                            if (treeNode.Level + 1 > this.iNodeLevels)
                            {
                                this.iNodeLevels = treeNode.Level + 1;
                            }
                            if (treeNode.Nodes.Count > 0)
                            {
                                this.myGetNodeLevels(treeNode.Nodes);
                            }
                            else
                            {
                                this.ColLists.Add(treeNode);
                            }
                        }
                    }
                    finally
                    {
                       
                    }
                    result = this.iNodeLevels;
                }
                return result;
            }
        }

        // Token: 0x060018C2 RID: 6338 RVA: 0x000CB6A4 File Offset: 0x000C98A4
        public void myNodeLevels()
        {
            this.hasshowerror = false;
            this.iNodeLevels = 0;
            this.ColLists.Clear();
            if (this._ColHeaderTreeView == null)
            {
                this.iCellHeight = this.ColumnHeadersHeight;
            }
            else
            {
                int num = this.myGetNodeLevels(this._ColHeaderTreeView.Nodes);
                if (num != 0)
                {
                    this.iCellHeight = checked((int)Math.Round((double)this.ColumnHeadersHeight / (double)num));
                }
            }
        }

        // Token: 0x060018C3 RID: 6339 RVA: 0x000CB710 File Offset: 0x000C9910
        private int GetUnitHeaderWidth(TreeNode node)
        {
            int num = 0;
            checked
            {
                int result;
                if (node.Nodes == null)
                {
                    if (this.Columns[this.GetColumnListNodeIndex(node)].Visible)
                    {
                        result = this.Columns[this.GetColumnListNodeIndex(node)].Width;
                    }
                    else
                    {
                        result = 0;
                    }
                }
                else if (node.Nodes.Count == 0)
                {
                    if (this.Columns[this.GetColumnListNodeIndex(node)].Visible)
                    {
                        result = this.Columns[this.GetColumnListNodeIndex(node)].Width;
                    }
                    else
                    {
                        result = 0;
                    }
                }
                else
                {
                    int num2 = 0;
                    int num3 = node.Nodes.Count - 1;
                    for (int i = num2; i <= num3; i++)
                    {
                        num += this.GetUnitHeaderWidth(node.Nodes[i]);
                    }
                    result = num;
                }
                return result;
            }
        }

        // Token: 0x060018C4 RID: 6340 RVA: 0x000CB7D8 File Offset: 0x000C99D8
        private int GetUnitHeaderWidth2(TreeNode node)
        {
            int num = 0;
            checked
            {
                int result;
                if (node.Nodes == null)
                {
                    if (this.Columns[this.GetColumnListNodeIndex(node)].Displayed)
                    {
                        result = this.Columns[this.GetColumnListNodeIndex(node)].Width;
                    }
                    else
                    {
                        result = 0;
                    }
                }
                else if (node.Nodes.Count == 0)
                {
                    if (this.Columns[this.GetColumnListNodeIndex(node)].Displayed)
                    {
                        result = this.Columns[this.GetColumnListNodeIndex(node)].Width;
                    }
                    else
                    {
                        result = 0;
                    }
                }
                else
                {
                    int num2 = 0;
                    int num3 = node.Nodes.Count - 1;
                    for (int i = num2; i <= num3; i++)
                    {
                        num += this.GetUnitHeaderWidth2(node.Nodes[i]);
                    }
                    result = num;
                }
                return result;
            }
        }

        // Token: 0x060018C5 RID: 6341 RVA: 0x000CB8A0 File Offset: 0x000C9AA0
        private int GetColumnListNodeIndex(TreeNode node)
        {
            checked
            {
                int result;
                if (node == null)
                {
                    result = -1;
                }
                else
                {
                    int num = 0;
                    int num2 = this.ColLists.Count - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        if (this.ColLists[i].Equals(node))
                        {
                            return i;
                        }
                    }
                    result = -1;
                }
                return result;
            }
        }

        // Token: 0x060018C6 RID: 6342 RVA: 0x000CB8EC File Offset: 0x000C9AEC
        public void PaintUnitHeader(TreeNode node, DataGridViewCellPaintingEventArgs e, int level, bool isusedisplayed = false)
        {
            if (level != 0)
            {
                new SolidBrush(this.GridColor);
                SolidBrush brush = new SolidBrush(e.CellStyle.BackColor);
                if (!node.BackColor.IsEmpty)
                {
                    brush = new SolidBrush(node.BackColor);
                }
                StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.FormatFlags &= ~StringFormatFlags.NoWrap;
                stringFormat.LineAlignment = StringAlignment.Center;
                int num;
                if (isusedisplayed)
                {
                    num = this.GetUnitHeaderWidth2(node);
                }
                else
                {
                    num = this.GetUnitHeaderWidth(node);
                }
                RectangleF layoutRectangle;
                if (node.Nodes.Count == 0)
                {
                    layoutRectangle = new RectangleF((float)e.CellBounds.Left, (float)(checked(e.CellBounds.Top + node.Level * this.iCellHeight)), (float)num - 1f, (float)(checked(this.iCellHeight * (this.iNodeLevels - node.Level))) - 1f);
                }
                else
                {
                    layoutRectangle = new RectangleF((float)e.CellBounds.Left, (float)(checked(e.CellBounds.Top + node.Level * this.iCellHeight)), (float)num - 1f, (float)this.iCellHeight - 1f);
                }
                e.Graphics.FillRectangle(brush, layoutRectangle.X, layoutRectangle.Y, layoutRectangle.Width, layoutRectangle.Height);
                if (node.Nodes.Count <= 0)
                {
                    e.Graphics.DrawLine(new Pen(this.GridColor), layoutRectangle.Left, layoutRectangle.Bottom, layoutRectangle.Right, layoutRectangle.Bottom);
                    e.Graphics.DrawLine(new Pen(this.GridColor), layoutRectangle.Right, layoutRectangle.Top, layoutRectangle.Right, layoutRectangle.Bottom);
                }
                else
                {
                    e.Graphics.DrawLine(new Pen(this.GridColor), layoutRectangle.Left, layoutRectangle.Bottom, layoutRectangle.Right, layoutRectangle.Bottom);
                    e.Graphics.DrawLine(new Pen(this.GridColor), layoutRectangle.Right, layoutRectangle.Top, layoutRectangle.Right, layoutRectangle.Bottom);
                }
                if (node.NodeFont == null)
                {
                    if (!node.ForeColor.IsEmpty)
                    {
                        e.Graphics.DrawString(node.Text, e.CellStyle.Font, new SolidBrush(node.ForeColor), layoutRectangle, stringFormat);
                    }
                    else
                    {
                        e.Graphics.DrawString(node.Text, e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor), layoutRectangle, stringFormat);
                    }
                }
                else if (!node.ForeColor.IsEmpty)
                {
                    e.Graphics.DrawString(node.Text, node.NodeFont, new SolidBrush(node.ForeColor), layoutRectangle, stringFormat);
                }
                else
                {
                    e.Graphics.DrawString(node.Text, node.NodeFont, new SolidBrush(e.CellStyle.ForeColor), layoutRectangle, stringFormat);
                }
                TreeNode treeNode = this.GetFirstNode(node);
                checked
                {
                    if (treeNode != null)
                    {
                        if (treeNode.Equals(node))
                        {
                            this.PaintUnitHeader(node.Parent, e, level - 1, isusedisplayed);
                        }
                        else
                        {
                            treeNode = this.GetFirstDisplayNode(node);
                            if (treeNode != null && treeNode.Equals(node))
                            {
                                this.PaintUnitHeader(node.Parent, e, level - 1, true);
                            }
                        }
                    }
                }
            }
        }

        // Token: 0x060018C7 RID: 6343 RVA: 0x000CBC64 File Offset: 0x000C9E64
        private TreeNode GetFirstNode(TreeNode tt)
        {
            TreeNode result;
            if (tt == null)
            {
                result = null;
            }
            else if (tt.Parent == null)
            {
                result = null;
            }
            else
            {
                TreeNode prevNode = tt.PrevNode;
                TreeNode treeNode = null;
                if (prevNode == null)
                {
                    treeNode = tt;
                }
                else
                {
                    while (prevNode != null)
                    {
                        treeNode = prevNode;
                        prevNode = prevNode.PrevNode;
                    }
                }
                if (treeNode == null)
                {
                    result = null;
                }
                else
                {
                    int num = 100000;
                    if (treeNode.Nodes.Count > 0)
                    {
                        TreeNode treeNode2 = null;
                        while (treeNode != null)
                        {
                            TreeNode node;
                            if (treeNode.Nodes.Count > 0)
                            {
                                node = this.GetFirstNodeLast(treeNode.FirstNode);
                            }
                            else
                            {
                                node = treeNode;
                            }
                            int columnListNodeIndex = this.GetColumnListNodeIndex(node);
                            if (columnListNodeIndex >= 0 && this.Columns[columnListNodeIndex].Visible && this.Columns[columnListNodeIndex].DisplayIndex < num)
                            {
                                num = this.Columns[columnListNodeIndex].DisplayIndex;
                                treeNode2 = treeNode;
                            }
                            treeNode = treeNode.NextNode;
                        }
                        result = treeNode2;
                    }
                    else
                    {
                        tt = treeNode;
                        num = 100000;
                        TreeNode treeNode3 = null;
                        try
                        {
                            while (tt != null)
                            {
                                int columnListNodeIndex = this.GetColumnListNodeIndex(tt);
                                if (columnListNodeIndex < 0)
                                {
                                    TreeNode firstNodeLast = this.GetFirstNodeLast(tt.FirstNode);
                                    columnListNodeIndex = this.GetColumnListNodeIndex(firstNodeLast);
                                }
                                if (columnListNodeIndex >= 0 && this.Columns[columnListNodeIndex].Visible && this.Columns[columnListNodeIndex].DisplayIndex < num)
                                {
                                    num = this.Columns[columnListNodeIndex].DisplayIndex;
                                    treeNode3 = tt;
                                }
                                tt = tt.NextNode;
                            }
                        }
                        catch (Exception ex)
                        {
                            return null;
                        }
                        result = treeNode3;
                    }
                }
            }
            return result;
        }

        // Token: 0x060018C8 RID: 6344 RVA: 0x000CBE00 File Offset: 0x000CA000
        private TreeNode GetFirstDisplayNode(TreeNode tt)
        {
            TreeNode result;
            if (tt.Parent == null)
            {
                result = null;
            }
            else
            {
                TreeNode prevNode = tt.PrevNode;
                TreeNode treeNode = null;
                if (prevNode == null)
                {
                    treeNode = tt;
                }
                else
                {
                    while (prevNode != null)
                    {
                        treeNode = prevNode;
                        prevNode = prevNode.PrevNode;
                    }
                }
                if (treeNode == null)
                {
                    result = null;
                }
                else
                {
                    int num = 100000;
                    if (treeNode.Nodes.Count > 0)
                    {
                        TreeNode treeNode2 = null;
                        while (treeNode != null)
                        {
                            TreeNode node;
                            if (treeNode.Nodes.Count > 0)
                            {
                                node = this.GetFirstDisplayNodeLast(treeNode.FirstNode);
                            }
                            else
                            {
                                node = treeNode;
                            }
                            int columnListNodeIndex = this.GetColumnListNodeIndex(node);
                            if (columnListNodeIndex >= 0 && this.Columns[columnListNodeIndex].Displayed && this.Columns[columnListNodeIndex].DisplayIndex < num)
                            {
                                num = this.Columns[columnListNodeIndex].DisplayIndex;
                                treeNode2 = treeNode;
                            }
                            treeNode = treeNode.NextNode;
                        }
                        result = treeNode2;
                    }
                    else
                    {
                        tt = treeNode;
                        num = 100000;
                        TreeNode treeNode3 = null;
                        try
                        {
                            while (tt != null)
                            {
                                int columnListNodeIndex = this.GetColumnListNodeIndex(tt);
                                if (columnListNodeIndex < 0)
                                {
                                    TreeNode firstDisplayNodeLast = this.GetFirstDisplayNodeLast(tt.FirstNode);
                                    columnListNodeIndex = this.GetColumnListNodeIndex(firstDisplayNodeLast);
                                }
                                if (columnListNodeIndex >= 0 && this.Columns[columnListNodeIndex].Displayed && this.Columns[columnListNodeIndex].DisplayIndex < num)
                                {
                                    num = this.Columns[columnListNodeIndex].DisplayIndex;
                                    treeNode3 = tt;
                                }
                                tt = tt.NextNode;
                            }
                        }
                        catch (Exception ex)
                        {
                            return null;
                        }
                        result = treeNode3;
                    }
                }
            }
            return result;
        }

        // Token: 0x060018C9 RID: 6345 RVA: 0x000CBF90 File Offset: 0x000CA190
        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0)
                {
                    base.OnCellPainting(e);
                }
                else if (e.RowIndex > -1 & e.ColumnIndex > -1)
                {
                    this.DrawCell(e);
                    base.OnCellPainting(e);
                }
                else if (this._ColHeaderTreeView == null)
                {
                    base.OnCellPainting(e);
                }
                else if (e.RowIndex == -1)
                {
                    if (this._ColHeaderTreeView != null)
                    {
                        if (this.iNodeLevels == 0)
                        {
                            this.myNodeLevels();
                        }
                        if (this.ColLists.Count != this.Columns.Count)
                        {
                            if (!this.hasshowerror)
                            {
                                this.hasshowerror = true;
                                Interaction.MsgBox(string.Concat(new string[]
                                {
                                    "无法正确绘制 ",
                                    this.Name,
                                    " 由TreeView表示的自定义表头，原因是您提供的用于绘制自定义表头的TreeView的叶节点个数[",
                                    Convert.ToString(this.ColLists.Count),
                                    "]与表格的列数[",
                                    Convert.ToString(this.ColumnCount),
                                    "]不相等\r\n\r\n说明：程序在绘制自定义表头时，TreeView的每个叶子节点对应到具体的表格的列，因此用于绘制自定义表头的TreeView的叶子节点个数必须与表格的列数相等，否则无法正确绘制"
                                }), MsgBoxStyle.OkOnly, "提示信息");
                            }
                            base.OnCellPainting(e);
                        }
                        else
                        {
                            TreeNode treeNode = this.ColLists[e.ColumnIndex];
                            if (treeNode.Level == 0)
                            {
                                if (treeNode.Nodes.Count <= 0)
                                {
                                    this.PaintUnitHeader(treeNode, e, this.iNodeLevels, false);
                                    e.Handled = true;
                                }
                                else
                                {
                                    this.PaintUnitHeader(treeNode, e, this.iNodeLevels, false);
                                    e.Handled = true;
                                }
                            }
                            else
                            {
                                this.PaintUnitHeader(treeNode, e, this.iNodeLevels, false);
                                e.Handled = true;
                            }
                        }
                    }
                    else
                    {
                        base.OnCellPainting(e);
                    }
                }
            }
            catch (Exception ex)
            {
                if (!this.hasshowerror)
                {
                    if (this._ColHeaderTreeView != null)
                    {
                        this.hasshowerror = true;
                        if (this.ColLists.Count != this.Columns.Count)
                        {
                            Interaction.MsgBox(string.Concat(new string[]
                            {
                                "绘制表头时出错，原因是您提供的用于绘制自定义表头的TreeView的叶节点个数[",
                                Convert.ToString(this.ColLists.Count),
                                "]与表格的列数[",
                                Convert.ToString(this.ColumnCount),
                                "]不相等\r\n\r\n说明：程序在绘制自定义表头时，TreeView的每个叶子节点对应到具体的表格的列，因此用于绘制自定义表头的TreeView的叶子节点个数必须与表格的列数相等，否则无法正确绘制"
                            }), MsgBoxStyle.OkOnly, ".NET轻松打印控件多表头组件");
                        }
                        else
                        {
                            Interaction.MsgBox("绘制表头时出错，错误信息为：" + ex.Message, MsgBoxStyle.OkOnly, ".NET轻松打印控件多表头组件");
                        }
                    }
                    else
                    {
                        Interaction.MsgBox("绘制表头时出错，错误信息为：" + ex.Message, MsgBoxStyle.OkOnly, ".NET轻松打印控件多表头组件");
                    }
                }
            }
        }

        // Token: 0x060018CA RID: 6346 RVA: 0x000CC214 File Offset: 0x000CA414
        protected override void OnColumnHeadersHeightChanged(EventArgs e)
        {
            if (this._ColHeaderTreeView == null)
            {
                base.OnColumnHeadersHeightChanged(e);
            }
            else
            {
                try
                {
                    this.myNodeLevels();
                }
                catch (Exception ex)
                {
                }
                base.OnColumnHeadersHeightChanged(e);
            }
        }

        // Token: 0x060018CB RID: 6347 RVA: 0x000CC260 File Offset: 0x000CA460
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            checked
            {
                if (!this._addrownumber)
                {
                    base.OnRowPostPaint(e);
                }
                else
                {
                    base.OnRowPostPaint(e);
                    if (!this.Rows[e.RowIndex].IsNewRow)
                    {
                        Color color = this.RowHeadersDefaultCellStyle.ForeColor;
                        if (this.Rows[e.RowIndex].Selected)
                        {
                            color = this.RowHeadersDefaultCellStyle.SelectionForeColor;
                        }
                        else
                        {
                            color = this.RowHeadersDefaultCellStyle.ForeColor;
                        }
                        SolidBrush brush = new SolidBrush(color);
                        StringFormat stringFormat = new StringFormat(StringFormat.GenericTypographic);
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;
                        Rectangle r = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.RowHeadersWidth - 4, e.RowBounds.Height);
                        e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, r, stringFormat);
                    }
                }
            }
        }

        // Token: 0x060018CC RID: 6348 RVA: 0x00008AD5 File Offset: 0x00006CD5
        protected override void OnColumnWidthChanged(DataGridViewColumnEventArgs e)
        {
            if (this._ColHeaderTreeView == null)
            {
                base.OnColumnWidthChanged(e);
            }
            else
            {
                base.OnColumnWidthChanged(e);
                this.Refresh();
            }
        }

        // Token: 0x060018CD RID: 6349 RVA: 0x000CC380 File Offset: 0x000CA580
        protected override void OnScroll(ScrollEventArgs e)
        {
            if (this._ColHeaderTreeView == null)
            {
                base.OnColumnHeadersHeightChanged(e);
                base.OnScroll(e);
            }
            else
            {
                base.OnScroll(e);
                if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
                {
                    if (e.NewValue < e.OldValue)
                    {
                        this.Refresh();
                    }
                    else if (!(e.Type == ScrollEventType.First | e.Type == ScrollEventType.LargeDecrement | e.Type == ScrollEventType.SmallDecrement))
                    {
                    }
                }
            }
        }

        // Token: 0x060018CE RID: 6350 RVA: 0x000CC3EC File Offset: 0x000CA5EC
        private TreeNode GetFirstDisplayNodeLast(TreeNode tt)
        {
            TreeNode result;
            if (tt == null)
            {
                result = null;
            }
            else if (tt.Parent == null)
            {
                result = tt;
            }
            else
            {
                TreeNode prevNode = tt.PrevNode;
                TreeNode treeNode = null;
                if (prevNode == null)
                {
                    treeNode = tt;
                }
                else
                {
                    while (prevNode != null)
                    {
                        treeNode = prevNode;
                        prevNode = prevNode.PrevNode;
                    }
                }
                if (treeNode == null)
                {
                    result = null;
                }
                else
                {
                    int num = 100000;
                    if (treeNode.Nodes.Count > 0)
                    {
                        TreeNode treeNode2 = null;
                        while (treeNode != null)
                        {
                            TreeNode treeNode3;
                            if (treeNode.Nodes.Count > 0)
                            {
                                treeNode3 = this.GetFirstDisplayNodeLast(treeNode.FirstNode);
                            }
                            else
                            {
                                treeNode3 = treeNode;
                            }
                            int columnListNodeIndex = this.GetColumnListNodeIndex(treeNode3);
                            if (columnListNodeIndex >= 0 && this.Columns[columnListNodeIndex].Displayed && this.Columns[columnListNodeIndex].DisplayIndex < num)
                            {
                                num = this.Columns[columnListNodeIndex].DisplayIndex;
                                treeNode2 = treeNode3;
                            }
                            treeNode = treeNode.NextNode;
                        }
                        result = treeNode2;
                    }
                    else
                    {
                        tt = treeNode;
                        num = 100000;
                        TreeNode treeNode4 = null;
                        try
                        {
                            while (tt != null)
                            {
                                TreeNode treeNode5 = tt;
                                int columnListNodeIndex = this.GetColumnListNodeIndex(tt);
                                if (columnListNodeIndex < 0)
                                {
                                    TreeNode firstDisplayNodeLast = this.GetFirstDisplayNodeLast(tt.FirstNode);
                                    columnListNodeIndex = this.GetColumnListNodeIndex(firstDisplayNodeLast);
                                    treeNode5 = firstDisplayNodeLast;
                                }
                                if (columnListNodeIndex >= 0 && this.Columns[columnListNodeIndex].Displayed && this.Columns[columnListNodeIndex].DisplayIndex < num)
                                {
                                    num = this.Columns[columnListNodeIndex].DisplayIndex;
                                    treeNode4 = treeNode5;
                                }
                                tt = tt.NextNode;
                            }
                        }
                        catch (Exception ex)
                        {
                            return null;
                        }
                        result = treeNode4;
                    }
                }
            }
            return result;
        }

        // Token: 0x060018CF RID: 6351 RVA: 0x000CC594 File Offset: 0x000CA794
        private TreeNode GetFirstNodeLast(TreeNode tt)
        {
            TreeNode result;
            if (tt == null)
            {
                result = null;
            }
            else if (tt.Parent == null)
            {
                result = tt;
            }
            else
            {
                TreeNode prevNode = tt.PrevNode;
                TreeNode treeNode = null;
                if (prevNode == null)
                {
                    treeNode = tt;
                }
                else
                {
                    while (prevNode != null)
                    {
                        treeNode = prevNode;
                        prevNode = prevNode.PrevNode;
                    }
                }
                if (treeNode == null)
                {
                    result = null;
                }
                else
                {
                    int num = 100000;
                    if (treeNode.Nodes.Count > 0)
                    {
                        TreeNode treeNode2 = null;
                        while (treeNode != null)
                        {
                            TreeNode treeNode3;
                            if (treeNode.Nodes.Count > 0)
                            {
                                treeNode3 = this.GetFirstNodeLast(treeNode.FirstNode);
                            }
                            else
                            {
                                treeNode3 = treeNode;
                            }
                            int columnListNodeIndex = this.GetColumnListNodeIndex(treeNode3);
                            if (columnListNodeIndex >= 0 && this.Columns[columnListNodeIndex].Visible && this.Columns[columnListNodeIndex].DisplayIndex < num)
                            {
                                num = this.Columns[columnListNodeIndex].DisplayIndex;
                                treeNode2 = treeNode3;
                            }
                            treeNode = treeNode.NextNode;
                        }
                        result = treeNode2;
                    }
                    else
                    {
                        tt = treeNode;
                        num = 100000;
                        TreeNode treeNode4 = null;
                        try
                        {
                            while (tt != null)
                            {
                                TreeNode treeNode5 = tt;
                                int columnListNodeIndex = this.GetColumnListNodeIndex(tt);
                                if (columnListNodeIndex < 0)
                                {
                                    TreeNode firstNodeLast = this.GetFirstNodeLast(tt.FirstNode);
                                    columnListNodeIndex = this.GetColumnListNodeIndex(firstNodeLast);
                                    treeNode5 = firstNodeLast;
                                }
                                if (columnListNodeIndex >= 0 && this.Columns[columnListNodeIndex].Visible && this.Columns[columnListNodeIndex].DisplayIndex < num)
                                {
                                    num = this.Columns[columnListNodeIndex].DisplayIndex;
                                    treeNode4 = treeNode5;
                                }
                                tt = tt.NextNode;
                            }
                        }
                        catch (Exception ex)
                        {
                            return null;
                        }
                        result = treeNode4;
                    }
                }
            }
            return result;
        }

        // Token: 0x060018D0 RID: 6352 RVA: 0x000CC73C File Offset: 0x000CA93C
        public void MergeSelectedCell()
        {
            checked
            {
                if (this.SelectedCells != null && this.SelectedCells.Count > 0)
                {
                    int dgvselectedMinRowIndex = Module1.GetDGVSelectedMinRowIndex(this);
                    int dgvselectedMaxRowIndex = Module1.GetDGVSelectedMaxRowIndex(this);
                    List<int> dgvselectedCols = Module1.GetDGVSelectedCols(this);
                    int displayIndex = this.Columns[dgvselectedCols[0]].DisplayIndex;
                    int displayIndex2 = this.Columns[dgvselectedCols[0]].DisplayIndex;
                    int index = dgvselectedCols[0];
                    int num = 1;
                    int num2 = dgvselectedCols.Count - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        if (displayIndex > this.Columns[dgvselectedCols[i]].DisplayIndex)
                        {
                            displayIndex = this.Columns[dgvselectedCols[i]].DisplayIndex;
                            index = dgvselectedCols[i];
                        }
                        if (displayIndex2 < this.Columns[dgvselectedCols[i]].DisplayIndex)
                        {
                            displayIndex2 = this.Columns[dgvselectedCols[i]].DisplayIndex;
                        }
                    }
                    this.MergeCell(dgvselectedMinRowIndex, dgvselectedMaxRowIndex, displayIndex, displayIndex2, RuntimeHelpers.GetObjectValue(this.Rows[dgvselectedMinRowIndex].Cells[index].FormattedValue), true);
                    dgvselectedCols.Clear();
                }
            }
        }

        // Token: 0x060018D1 RID: 6353 RVA: 0x000CC87C File Offset: 0x000CAA7C
        public void CancelMergeSelectedCell()
        {
            checked
            {
                if (this.SelectedCells.Count > 0)
                {
                    int dgvselectedMinRowIndex = Module1.GetDGVSelectedMinRowIndex(this);
                    int dgvselectedMaxRowIndex = Module1.GetDGVSelectedMaxRowIndex(this);
                    bool[] array = new bool[this.Columns.Count - 1 + 1];
                    int num = 0;
                    int num2 = this.Columns.Count - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        array[i] = false;
                    }
                    List<int> dgvselectedCols = Module1.GetDGVSelectedCols(this);
                    int num3 = 0;
                    int num4 = dgvselectedCols.Count - 1;
                    for (int j = num3; j <= num4; j++)
                    {
                        array[dgvselectedCols[j]] = true;
                    }
                    int displayIndex = this.Columns[dgvselectedCols[0]].DisplayIndex;
                    int displayIndex2 = this.Columns[dgvselectedCols[0]].DisplayIndex;
                    int index = dgvselectedCols[0];
                    int num5 = 1;
                    int num6 = dgvselectedCols.Count - 1;
                    for (int k = num5; k <= num6; k++)
                    {
                        if (displayIndex > this.Columns[dgvselectedCols[k]].DisplayIndex)
                        {
                            displayIndex = this.Columns[dgvselectedCols[k]].DisplayIndex;
                            index = dgvselectedCols[k];
                        }
                        if (displayIndex2 < this.Columns[dgvselectedCols[k]].DisplayIndex)
                        {
                            displayIndex2 = this.Columns[dgvselectedCols[k]].DisplayIndex;
                        }
                    }
                    this.MergeCell(dgvselectedMinRowIndex, dgvselectedMaxRowIndex, displayIndex, displayIndex2, RuntimeHelpers.GetObjectValue(this.Rows[dgvselectedMinRowIndex].Cells[index].Value), false);
                }
            }
        }

        // Token: 0x060018D2 RID: 6354 RVA: 0x00008AF5 File Offset: 0x00006CF5
        public void CancelMergeCell(int startrow, int endrow, int startcolumn, int endcolumn)
        {
            this.MergeCell(startrow, endrow, startcolumn, endcolumn, null, false);
        }

        // Token: 0x060018D3 RID: 6355 RVA: 0x000CCA0C File Offset: 0x000CAC0C
        public void MergeCell(int startrow, int endrow, int startcolumn, int endcolumn)
        {
            int index = 0;
            int num = 0;
            checked
            {
                int num2 = this.Columns.Count - 1;
                for (int i = num; i <= num2; i++)
                {
                    if (this.Columns[i].DisplayIndex == startcolumn)
                    {
                        index = i;
                    IL_38:
                        object objectValue = RuntimeHelpers.GetObjectValue(this.Rows[startrow].Cells[index].Value);
                        this.MergeCell(startrow, endrow, startcolumn, endcolumn, RuntimeHelpers.GetObjectValue(objectValue), true);
                        return;
                    }
                }

            }
        }

        // Token: 0x060018D4 RID: 6356 RVA: 0x00008B04 File Offset: 0x00006D04
        public void MergeCell(int startrow, int endrow, int startcolumn, int endcolumn, object value)
        {
            this.MergeCell(startrow, endrow, startcolumn, endcolumn, RuntimeHelpers.GetObjectValue(value), true);
        }

        // Token: 0x060018D5 RID: 6357 RVA: 0x000CCA88 File Offset: 0x000CAC88
        private void MergeCell(int startrow, int endrow, int startcolumn, int endcolumn, object value, bool ismerged)
        {
            checked
            {
                if (this.RowCount > 0 && this.ColumnCount > 0 && !(startrow < 0 | startcolumn < 0))
                {
                    if (endrow > this.RowCount - 1)
                    {
                        endrow = this.RowCount - 1;
                    }
                    if (endrow >= startrow)
                    {
                        if (endcolumn > this.ColumnCount - 1)
                        {
                            endcolumn = this.ColumnCount - 1;
                        }
                        if (endcolumn >= startcolumn)
                        {
                            int columnCount = this.ColumnCount;
                            int[] array = new int[columnCount - 1 + 1];
                            int[] array2 = new int[columnCount - 1 + 1];
                            int num = 0;
                            int num2 = columnCount - 1;
                            for (int i = num; i <= num2; i++)
                            {
                                array2[i] = i;
                            }
                            int[] array3 = new int[columnCount - 1 + 1];
                            int num3 = 0;
                            int num4 = columnCount - 1;
                            for (int j = num3; j <= num4; j++)
                            {
                                array[j] = array2[j];
                                array3[j] = this.Columns[array2[j]].DisplayIndex;
                            }
                            Array.Sort<int, int>(array3, array);
                            if (startcolumn == endcolumn & startrow == endrow)
                            {
                                this.Rows[startrow].Cells[array[startcolumn]].Tag = "";
                                if (ismerged)
                                {
                                    this.Rows[startrow].Cells[array[startcolumn]].Value = RuntimeHelpers.GetObjectValue(value);
                                }
                                this.RefreshMergeSetting();
                            }
                            else
                            {
                                DataGridViewCellStyle style;
                                if (this.Rows[startrow].Cells[array[startcolumn]].HasStyle)
                                {
                                    style = this.Rows[startrow].Cells[array[startcolumn]].Style.Clone();
                                }
                                else
                                {
                                    style = null;
                                }
                                if (startrow == endrow)
                                {
                                    int num5 = endcolumn;
                                    for (int k = startcolumn; k <= num5; k++)
                                    {
                                        if (ismerged)
                                        {
                                            if (k == startcolumn)
                                            {
                                                this.Rows[startrow].Cells[array[k]].Tag = "右合并";
                                            }
                                            else if (k == endcolumn)
                                            {
                                                this.Rows[startrow].Cells[array[k]].Tag = "左合并";
                                            }
                                            else
                                            {
                                                this.Rows[startrow].Cells[array[k]].Tag = "水平合并";
                                            }
                                            this.Rows[startrow].Cells[array[k]].Value = RuntimeHelpers.GetObjectValue(value);
                                            this.Rows[startrow].Cells[array[k]].Style = style;
                                        }
                                        else
                                        {
                                            this.Rows[startrow].Cells[array[k]].Tag = "";
                                        }
                                    }
                                }
                                else if (startcolumn == endcolumn)
                                {
                                    int num6 = endrow;
                                    for (int l = startrow; l <= num6; l++)
                                    {
                                        if (ismerged)
                                        {
                                            if (l == startrow)
                                            {
                                                this.Rows[l].Cells[array[startcolumn]].Tag = "下合并";
                                            }
                                            else if (l == endrow)
                                            {
                                                this.Rows[l].Cells[array[startcolumn]].Tag = "上合并";
                                            }
                                            else
                                            {
                                                this.Rows[l].Cells[array[startcolumn]].Tag = "垂直合并";
                                            }
                                            this.Rows[l].Cells[array[startcolumn]].Value = RuntimeHelpers.GetObjectValue(value);
                                            this.Rows[l].Cells[array[startcolumn]].Style = style;
                                        }
                                        else
                                        {
                                            this.Rows[l].Cells[array[startcolumn]].Tag = "";
                                        }
                                    }
                                }
                                else
                                {
                                    int num7 = endrow;
                                    for (int m = startrow; m <= num7; m++)
                                    {
                                        int num8 = endcolumn;
                                        for (int n = startcolumn; n <= num8; n++)
                                        {
                                            if (ismerged)
                                            {
                                                if (m == startrow & n == startcolumn)
                                                {
                                                    this.Rows[m].Cells[array[n]].Tag = "右下合并";
                                                }
                                                else if (m == endrow & n == endcolumn)
                                                {
                                                    this.Rows[m].Cells[array[n]].Tag = "左上合并";
                                                }
                                                else if (m == endrow & n == startcolumn)
                                                {
                                                    this.Rows[m].Cells[array[n]].Tag = "右上合并";
                                                }
                                                else if (m == startrow & n == endcolumn)
                                                {
                                                    this.Rows[m].Cells[array[n]].Tag = "左下合并";
                                                }
                                                else if (n == startcolumn)
                                                {
                                                    this.Rows[m].Cells[array[n]].Tag = "右边合并";
                                                }
                                                else if (n == endcolumn)
                                                {
                                                    this.Rows[m].Cells[array[n]].Tag = "左边合并";
                                                }
                                                else if (m == startrow)
                                                {
                                                    this.Rows[m].Cells[array[n]].Tag = "下边合并";
                                                }
                                                else if (m == endrow)
                                                {
                                                    this.Rows[m].Cells[array[n]].Tag = "上边合并";
                                                }
                                                else
                                                {
                                                    this.Rows[m].Cells[array[n]].Tag = "合并";
                                                }
                                                this.Rows[m].Cells[array[n]].Value = RuntimeHelpers.GetObjectValue(value);
                                                this.Rows[m].Cells[array[n]].Style = style;
                                            }
                                            else
                                            {
                                                this.Rows[m].Cells[array[n]].Tag = "";
                                            }
                                        }
                                    }
                                }
                                this.RefreshMergeSetting();
                            }
                        }
                    }
                }
            }
        }

        // Token: 0x060018D6 RID: 6358 RVA: 0x000CD0B8 File Offset: 0x000CB2B8
        private void MulHeaderDataGridView_Disposed(object sender, EventArgs e)
        {
            try
            {
                this._ColHeaderTreeView = null;
                this.ColLists.Clear();
                this.ColLists = null;
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x060018D7 RID: 6359 RVA: 0x000CD100 File Offset: 0x000CB300
        public bool ExportToExcel(string title)
        {
            return DGVtoExcel.DGVToExcel(this, this.ColHeaderTreeView, title, "", "", "", true);
        }

        // Token: 0x060018D8 RID: 6360 RVA: 0x000CD12C File Offset: 0x000CB32C
        public bool ExportToExcel(string title, string filename)
        {
            return DGVtoExcel.DGVToExcel(this, this.ColHeaderTreeView, title, filename, "", "", true);
        }

        // Token: 0x060018D9 RID: 6361 RVA: 0x000CD154 File Offset: 0x000CB354
        public bool ImportFromExcel(string filename, bool replaceRowHeaderRow, bool isaddmode)
        {
            return ExcelToDGV.ImportExcelToDGV(filename, this, replaceRowHeaderRow, isaddmode);
        }

        // Token: 0x060018DA RID: 6362 RVA: 0x000CD16C File Offset: 0x000CB36C
        public bool ImportFromExcel(string filename)
        {
            bool result;
            if (this == null)
            {
                result = false;
            }
            else
            {
                bool allowUserToAddRows = this.AllowUserToAddRows;
                this.AllowUserToAddRows = false;
                bool flag;
                if (this.ColumnCount <= 0)
                {
                    flag = ExcelToDGV.ImportExcelToDGV(filename, this, true, false);
                }
                else
                {
                    flag = ExcelToDGV.ImportExcelToDGV(filename, this, false, true);
                }
                this.AllowUserToAddRows = allowUserToAddRows;
                result = flag;
            }
            return result;
        }

        // Token: 0x060018DB RID: 6363 RVA: 0x00008B19 File Offset: 0x00006D19
        public void Copy(DataGridView dgv)
        {
            Clipboard.SetDataObject(RuntimeHelpers.GetObjectValue(dgv.GetClipboardContent().GetData(DataFormats.Text)));
        }

        // Token: 0x060018DC RID: 6364 RVA: 0x00008B35 File Offset: 0x00006D35
        public void Copy()
        {
            Clipboard.SetDataObject(RuntimeHelpers.GetObjectValue(this.GetClipboardContent().GetData(DataFormats.Text)));
        }

        // Token: 0x060018DD RID: 6365 RVA: 0x000CD1B8 File Offset: 0x000CB3B8
        public bool Paste()
        {
            return this.Paste(this);
        }

        // Token: 0x060018DE RID: 6366 RVA: 0x000CD1CC File Offset: 0x000CB3CC
        public bool Paste(DataGridView mydgv)
        {
            checked
            {
                try
                {
                    if (mydgv.CurrentCell == null)
                    {
                        return false;
                    }
                    string text = Clipboard.GetText();
                    if (text == null)
                    {
                        return false;
                    }
                    if (string.IsNullOrEmpty(text))
                    {
                        return false;
                    }
                    int columnCount = mydgv.ColumnCount;
                    if (columnCount <= 0)
                    {
                        return false;
                    }
                    if (mydgv.RowCount <= 0)
                    {
                        return false;
                    }
                    int[] array = new int[columnCount - 1 + 1];
                    int[] array2 = new int[columnCount - 1 + 1];
                    int num = 0;
                    int num2 = 0;
                    int num3 = columnCount - 1;
                    for (int i = num2; i <= num3; i++)
                    {
                        array[i] = i;
                        array2[i] = mydgv.Columns[i].DisplayIndex;
                        if (mydgv.Columns[i].Visible)
                        {
                            num++;
                        }
                    }
                    if (num <= 0)
                    {
                        return false;
                    }
                    Array.Sort<int, int>(array2, array);
                    int[] array3 = new int[num - 1 + 1];
                    int j = 0;
                    int rowIndex = mydgv.CurrentCell.RowIndex;
                    int num4 = mydgv.CurrentCell.ColumnIndex;
                    int num5 = 0;
                    int num6 = columnCount - 1;
                    for (int i = num5; i <= num6; i++)
                    {
                        if (mydgv.Columns[array[i]].Visible)
                        {
                            array3[j] = array[i];
                            if (array[i] == mydgv.CurrentCell.ColumnIndex)
                            {
                                num4 = j;
                            }
                            j++;
                        }
                        else if (array[i] == mydgv.CurrentCell.ColumnIndex)
                        {
                            num4 = j;
                        }
                    }
                    if (String.Compare(Strings.Right(text, 1), "\r", false) == 0 | String.Compare(Strings.Right(text, 1), "\n", false) == 0)
                    {
                        text = Strings.Left(text, text.Length - 1);
                    }
                    string[] array4 = Strings.Split(text, "\r\n", -1, CompareMethod.Binary);
                    int num7 = rowIndex;
                    if (mydgv.SelectedCells != null && mydgv.SelectedCells.Count > 1)
                    {
                        List<int> dgvselectedRows = Module1.GetDGVSelectedRows(mydgv);
                        List<int> dgvselectedCols = Module1.GetDGVSelectedCols(mydgv);
                        int[] array5 = new int[dgvselectedCols.Count - 1 + 1];
                        int[] array6 = new int[dgvselectedCols.Count - 1 + 1];
                        int num8 = 0;
                        int num9 = dgvselectedCols.Count - 1;
                        for (int i = num8; i <= num9; i++)
                        {
                            array5[i] = dgvselectedCols[i];
                            array6[i] = mydgv.Columns[array5[i]].DisplayIndex;
                        }
                        int[] array7 = new int[dgvselectedRows.Count - 1 + 1];
                        int num10 = 0;
                        int num11 = dgvselectedRows.Count - 1;
                        for (int i = num10; i <= num11; i++)
                        {
                            array7[i] = dgvselectedRows[i];
                        }
                        Array.Sort<int>(array7);
                        Array.Sort<int, int>(array6, array5);
                        int num12 = 0;
                        int num13 = 0;
                        int num14 = array7.Length - 1;
                        for (int i = num13; i <= num14; i++)
                        {
                            if (num12 >= array4.Length)
                            {
                                num12 = 0;
                            }
                            int num15 = 0;
                            string[] array8 = Strings.Split(array4[num12], "\t", -1, CompareMethod.Binary);
                            int num16 = 0;
                            int num17 = array5.Length - 1;
                            for (j = num16; j <= num17; j++)
                            {
                                if (num15 >= array8.Length)
                                {
                                    num15 = 0;
                                }
                                mydgv.Rows[array7[i]].Cells[array5[j]].Value = array8[num15];
                                num15++;
                            }
                            num12++;
                        }
                    }
                    else
                    {
                        int num18 = 0;
                        int num19 = array4.Length - 1;
                        for (int i = num18; i <= num19; i++)
                        {
                            if (num7 >= mydgv.RowCount)
                            {
                                break;
                            }
                            while (!mydgv.Rows[num7].Visible)
                            {
                                num7++;
                                if (num7 >= mydgv.RowCount)
                                {
                                    goto IL_3F6;
                                }
                            }
                            string[] array8 = Strings.Split(array4[i], "\t", -1, CompareMethod.Binary);
                            int num20 = num4;
                            int num21 = 0;
                            int num22 = array8.Length - 1;
                            j = num21;
                            while (j <= num22 && num20 < array3.Length)
                            {
                                mydgv.Rows[num7].Cells[array3[num20]].Value = array8[j];
                                num20++;
                                j++;
                            }
                            num7++;
                        }
                    }
                IL_3F6:;
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("粘贴失败：" + ex.Message, MsgBoxStyle.OkOnly, "提示信息");
                    return false;
                }
                return true;
            }
        }

        // Token: 0x04000B9C RID: 2972
        private TreeView _ColHeaderTreeView;

        // Token: 0x04000B9D RID: 2973
        private int iNodeLevels;

        // Token: 0x04000B9E RID: 2974
        private int iCellHeight;

        // Token: 0x04000B9F RID: 2975
        private IList<TreeNode> ColLists;

        // Token: 0x04000BA0 RID: 2976
        private const float HH = 1f;

        // Token: 0x04000BA1 RID: 2977
        private bool hasshowerror;

        // Token: 0x04000BA2 RID: 2978
        private bool _addrownumber;
    }
}
