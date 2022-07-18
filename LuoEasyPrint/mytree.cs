using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x020000D3 RID: 211
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class mytree : IDisposable
	{
		// Token: 0x060018E4 RID: 6372 RVA: 0x000CEE10 File Offset: 0x000CD010
		public void SetDVGHeaderText()
		{
			checked
			{
				try
				{
					int num = 0;
					int num2 = this.mydgv.ColumnCount - 1;
					for (int i = num; i <= num2; i++)
					{
						this.mydgv.Columns[i].HeaderText = Strings.Trim(this.ColLists[i].Text + "");
						try
						{
							this.mydgv.Columns[i].Name = Strings.Trim(this.ColLists[i].Text + "");
						}
						catch (Exception ex)
						{
							this.mydgv.Columns[i].Name = "第" + Conversions.ToString(i + 1) + "列";
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00008B51 File Offset: 0x00006D51
		public mytree(TreeView Tre, DataGridView DGV)
		{
			this.ColLists = new List<TreeNode>();
			this.mydgv = DGV;
			this.iNodeLevels = 1;
			this._ColHeaderTreeView = Tre;
			this.myNodeLevels();
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00008B7F File Offset: 0x00006D7F
		public mytree(TreeView Tre, DataGridView DGV, float[] colwidth)
		{
			this.ColLists = new List<TreeNode>();
			this.mydgv = DGV;
			this.iNodeLevels = 1;
			this._ColHeaderTreeView = Tre;
			this.columnwidth = colwidth;
			this.myNodeLevels();
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00008BB4 File Offset: 0x00006DB4
		public mytree(TreeView Tre, DataGridView DGV, float[] colwidth, int columnheaderheight)
		{
			this.ColLists = new List<TreeNode>();
			this.mydgv = DGV;
			this.iNodeLevels = 1;
			this._ColHeaderTreeView = Tre;
			this.columnwidth = colwidth;
			this.myNodeLevels(columnheaderheight);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x000CEF14 File Offset: 0x000CD114
		public int GetColumns()
		{
			return this.ColLists.Count;
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x000CEF30 File Offset: 0x000CD130
		public int GetLeves()
		{
			return this.iNodeLevels;
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x000CEF48 File Offset: 0x000CD148
		public int GetSingleHeight()
		{
			return this.iCellHeight;
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x000CEF60 File Offset: 0x000CD160
		private TreeNode GetLevelNode(TreeNode node, int mylevel)
		{
			checked
			{
				TreeNode result;
				if (node == null)
				{
					result = null;
				}
				else if (node.Level + 1 == mylevel)
				{
					result = node;
				}
				else if (node.Level + 1 < mylevel)
				{
					result = null;
				}
				else
				{
					result = this.GetLevelNode(node.Parent, mylevel);
				}
				return result;
			}
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x000CEFA4 File Offset: 0x000CD1A4
		public float GetCellHeight(int colindex, int mylevel)
		{
			TreeNode nodeByColIndex = this.GetNodeByColIndex(colindex);
			TreeNode levelNode = this.GetLevelNode(nodeByColIndex, mylevel);
			float result;
			if (levelNode == null)
			{
				result = 0f;
			}
			else if (nodeByColIndex.Equals(levelNode))
			{
				result = (float)(checked((this.iNodeLevels - mylevel + 1) * this.iCellHeight));
			}
			else
			{
				result = (float)this.iCellHeight;
			}
			return result;
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x000CEFF4 File Offset: 0x000CD1F4
		public string GetNodeText(int colindex, int mylevel)
		{
			TreeNode nodeByColIndex = this.GetNodeByColIndex(colindex);
			TreeNode levelNode = this.GetLevelNode(nodeByColIndex, mylevel);
			string result;
			if (levelNode == null)
			{
				result = "";
			}
			else
			{
				result = levelNode.Text;
			}
			return result;
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x000CF028 File Offset: 0x000CD228
		public Color GetNodeForeColor(int colindex, int mylevel)
		{
			TreeNode nodeByColIndex = this.GetNodeByColIndex(colindex);
			TreeNode levelNode = this.GetLevelNode(nodeByColIndex, mylevel);
			Color result;
			if (levelNode == null)
			{
				result = Color.Empty;
			}
			else
			{
				result = levelNode.ForeColor;
			}
			return result;
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x000CF05C File Offset: 0x000CD25C
		public Color GetNodeBackColor(int colindex, int mylevel)
		{
			TreeNode nodeByColIndex = this.GetNodeByColIndex(colindex);
			TreeNode levelNode = this.GetLevelNode(nodeByColIndex, mylevel);
			Color result;
			if (levelNode == null)
			{
				result = Color.Empty;
			}
			else
			{
				result = levelNode.BackColor;
			}
			return result;
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x000CF090 File Offset: 0x000CD290
		public Font GetNodeFont(int colindex, int mylevel)
		{
			TreeNode nodeByColIndex = this.GetNodeByColIndex(colindex);
			TreeNode levelNode = this.GetLevelNode(nodeByColIndex, mylevel);
			Font result;
			if (levelNode == null)
			{
				result = null;
			}
			else
			{
				result = levelNode.NodeFont;
			}
			return result;
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x000CF0C0 File Offset: 0x000CD2C0
		public float GetCellWidth(int colindex, int mylevel)
		{
			TreeNode nodeByColIndex = this.GetNodeByColIndex(colindex);
			TreeNode levelNode = this.GetLevelNode(nodeByColIndex, mylevel);
			float result;
			if (levelNode == null)
			{
				result = 0f;
			}
			else if (levelNode.Nodes.Count <= 0)
			{
				result = this.GetUnitHeaderWidth(levelNode);
			}
			else
			{
				TreeNode firstNode = this.GetFirstNode(levelNode.FirstNode);
				if (firstNode.Equals(nodeByColIndex))
				{
					result = this.GetUnitHeaderWidth(levelNode);
				}
				else
				{
					result = 0f;
				}
			}
			return result;
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x000CF12C File Offset: 0x000CD32C
		public float GetCellWidth2(int colindex, int mylevel)
		{
			TreeNode nodeByColIndex = this.GetNodeByColIndex(colindex);
			TreeNode levelNode = this.GetLevelNode(nodeByColIndex, mylevel);
			float result;
			if (levelNode == null)
			{
				result = this.columnwidth[colindex];
			}
			else if (levelNode.Nodes.Count <= 0)
			{
				result = this.GetUnitHeaderWidth(levelNode);
			}
			else
			{
				result = this.GetUnitHeaderWidth(levelNode);
			}
			return result;
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x000CF17C File Offset: 0x000CD37C
		private TreeNode GetFirstNode(TreeNode tt)
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
								treeNode3 = this.GetFirstNode(treeNode.FirstNode);
							}
							else
							{
								treeNode3 = treeNode;
							}
							int columnListNodeIndex = this.GetColumnListNodeIndex(treeNode3);
							if (columnListNodeIndex >= 0 && this.mydgv.Columns[columnListNodeIndex].Visible && this.mydgv.Columns[columnListNodeIndex].DisplayIndex < num)
							{
								num = this.mydgv.Columns[columnListNodeIndex].DisplayIndex;
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
									TreeNode firstNode = this.GetFirstNode(tt.FirstNode);
									columnListNodeIndex = this.GetColumnListNodeIndex(firstNode);
									treeNode5 = firstNode;
								}
								if (columnListNodeIndex >= 0 && this.mydgv.Columns[columnListNodeIndex].Visible && this.mydgv.Columns[columnListNodeIndex].DisplayIndex < num)
								{
									num = this.mydgv.Columns[columnListNodeIndex].DisplayIndex;
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

		// Token: 0x060018F4 RID: 6388 RVA: 0x000CF34C File Offset: 0x000CD54C
		private TreeNode GetNodeByColIndex(int colindex)
		{
			return this.ColLists[colindex];
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x000CF368 File Offset: 0x000CD568
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

		// Token: 0x060018F6 RID: 6390 RVA: 0x000CF414 File Offset: 0x000CD614
		private void myNodeLevels()
		{
			this.iNodeLevels = 1;
			this.ColLists.Clear();
			if (this._ColHeaderTreeView == null)
			{
				this.iCellHeight = this.mydgv.ColumnHeadersHeight;
			}
			else
			{
				int num = this.myGetNodeLevels(this._ColHeaderTreeView.Nodes);
				if (num != 0)
				{
					this.iCellHeight = checked((int)Math.Round((double)this.mydgv.ColumnHeadersHeight / (double)num));
				}
				else
				{
					this.iCellHeight = this.mydgv.ColumnHeadersHeight;
				}
			}
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x000CF494 File Offset: 0x000CD694
		private void myNodeLevels(int Columnheaderheight)
		{
			this.iNodeLevels = 1;
			this.ColLists.Clear();
			if (this._ColHeaderTreeView == null)
			{
				this.iCellHeight = Columnheaderheight;
			}
			else
			{
				int num = this.myGetNodeLevels(this._ColHeaderTreeView.Nodes);
				if (num != 0)
				{
					this.iCellHeight = checked((int)Math.Round((double)Columnheaderheight / (double)num));
				}
				else
				{
					this.iCellHeight = Columnheaderheight;
				}
			}
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x000CF4F8 File Offset: 0x000CD6F8
		private float GetUnitHeaderWidth(TreeNode node)
		{
			float num = 0f;
			int columnListNodeIndex = this.GetColumnListNodeIndex(node);
			checked
			{
				float result;
				if (node.Nodes == null)
				{
					if (this.mydgv.Columns[columnListNodeIndex].Visible)
					{
						result = this.columnwidth[columnListNodeIndex];
					}
					else
					{
						result = 0f;
					}
				}
				else if (node.Nodes.Count == 0)
				{
					if (this.mydgv.Columns[columnListNodeIndex].Visible)
					{
						result = this.columnwidth[columnListNodeIndex];
					}
					else
					{
						result = 0f;
					}
				}
				else
				{
					int num2 = 0;
					int num3 = node.Nodes.Count - 1;
					for (int i = num2; i <= num3; i++)
					{
						unchecked
						{
							num += this.GetUnitHeaderWidth(node.Nodes[i]);
						}
					}
					result = num;
				}
				return result;
			}
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x000CF5B4 File Offset: 0x000CD7B4
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

		// Token: 0x060018FA RID: 6394 RVA: 0x000CF600 File Offset: 0x000CD800
		private int GetUnitHeaderWidthCols(TreeNode node)
		{
			int num = 0;
			int columnListNodeIndex = this.GetColumnListNodeIndex(node);
			checked
			{
				int result;
				if (node.Nodes == null)
				{
					if (this.mydgv.Columns[columnListNodeIndex].Visible)
					{
						result = 1;
					}
					else
					{
						result = 0;
					}
				}
				else if (node.Nodes.Count == 0)
				{
					if (this.mydgv.Columns[columnListNodeIndex].Visible)
					{
						result = 1;
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
						num += this.GetUnitHeaderWidthCols(node.Nodes[i]);
					}
					result = num;
				}
				return result;
			}
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x000CF6A4 File Offset: 0x000CD8A4
		public int GetCellWidthCols(int colindex, int mylevel)
		{
			TreeNode nodeByColIndex = this.GetNodeByColIndex(colindex);
			TreeNode levelNode = this.GetLevelNode(nodeByColIndex, mylevel);
			int result;
			if (levelNode == null)
			{
				result = 0;
			}
			else if (levelNode.Nodes.Count <= 0)
			{
				result = this.GetUnitHeaderWidthCols(levelNode);
			}
			else
			{
				TreeNode firstNode = this.GetFirstNode(levelNode.FirstNode);
				if (firstNode.Equals(nodeByColIndex))
				{
					result = this.GetUnitHeaderWidthCols(levelNode);
				}
				else
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x000CF708 File Offset: 0x000CD908
		public int GetCellHeightLevels(int colindex, int mylevel)
		{
			TreeNode nodeByColIndex = this.GetNodeByColIndex(colindex);
			TreeNode levelNode = this.GetLevelNode(nodeByColIndex, mylevel);
			int result;
			if (levelNode == null)
			{
				result = 0;
			}
			else if (nodeByColIndex.Equals(levelNode))
			{
				result = checked(this.iNodeLevels - mylevel + 1);
			}
			else
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x000CF748 File Offset: 0x000CD948
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue && disposing)
			{
				try
				{
					this.mydgv = null;
					this.columnwidth = null;
					this._ColHeaderTreeView = null;
					this.ColLists.Clear();
					this.ColLists = null;
				}
				catch (Exception ex)
				{
				}
			}
			this.disposedValue = true;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00008BEB File Offset: 0x00006DEB
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000BA3 RID: 2979
		private int iNodeLevels;

		// Token: 0x04000BA4 RID: 2980
		private int iCellHeight;

		// Token: 0x04000BA5 RID: 2981
		private IList<TreeNode> ColLists;

		// Token: 0x04000BA6 RID: 2982
		private TreeView _ColHeaderTreeView;

		// Token: 0x04000BA7 RID: 2983
		private DataGridView mydgv;

		// Token: 0x04000BA8 RID: 2984
		private float[] columnwidth;

		// Token: 0x04000BA9 RID: 2985
		private bool disposedValue;
	}
}
