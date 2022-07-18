using System.ComponentModel;

namespace LuoEasyPrint
{
	public partial class TextEdit_Express : System.Windows.Forms.Form
	{
		// Token: 0x060009D5 RID: 2517 RVA: 0x00059B14 File Offset: 0x00057D14
		[System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00059B54 File Offset: 0x00057D54
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new System.Windows.Forms.Button();
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.ContextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Button3 = new System.Windows.Forms.Button();
			this.ContextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.TableLayoutPanel1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.TableLayoutPanel1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			System.Windows.Forms.Control tableLayoutPanel = this.TableLayoutPanel1;
			System.Drawing.Point location = new System.Drawing.Point(297, 203);
			tableLayoutPanel.Location = location;
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			System.Windows.Forms.Control tableLayoutPanel2 = this.TableLayoutPanel1;
			System.Drawing.Size size = new System.Drawing.Size(146, 27);
			tableLayoutPanel2.Size = size;
			this.TableLayoutPanel1.TabIndex = 0;
			this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			System.Windows.Forms.Control ok_Button = this.OK_Button;
			location = new System.Drawing.Point(3, 3);
			ok_Button.Location = location;
			this.OK_Button.Name = "OK_Button";
			System.Windows.Forms.Control ok_Button2 = this.OK_Button;
			size = new System.Drawing.Size(67, 21);
			ok_Button2.Size = size;
			this.OK_Button.TabIndex = 0;
			this.OK_Button.Text = "确定";
			this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			System.Windows.Forms.Control cancel_Button = this.Cancel_Button;
			location = new System.Drawing.Point(76, 3);
			cancel_Button.Location = location;
			this.Cancel_Button.Name = "Cancel_Button";
			System.Windows.Forms.Control cancel_Button2 = this.Cancel_Button;
			size = new System.Drawing.Size(67, 21);
			cancel_Button2.Size = size;
			this.Cancel_Button.TabIndex = 1;
			this.Cancel_Button.Text = "取消";
			this.Panel1.Controls.Add(this.TextBox1);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			System.Windows.Forms.Control panel = this.Panel1;
			location = new System.Drawing.Point(0, 0);
			panel.Location = location;
			this.Panel1.Name = "Panel1";
			System.Windows.Forms.Control panel2 = this.Panel1;
			size = new System.Drawing.Size(443, 193);
			panel2.Size = size;
			this.Panel1.TabIndex = 1;
			this.TextBox1.AcceptsReturn = true;
			this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBox1.Font = new System.Drawing.Font("宋体", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			this.TextBox1.HideSelection = false;
			System.Windows.Forms.Control textBox = this.TextBox1;
			location = new System.Drawing.Point(0, 0);
			textBox.Location = location;
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new System.Drawing.Size(443, 193);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 1;
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem_0,
				this.ToolStripMenuItem_1,
				this.ToolStripMenuItem_2,
				this.ToolStripMenuItem_3,
				this.ToolStripMenuItem_4,
				this.ToolStripMenuItem1,
				this.ToolStripMenuItem2,
				this.ToolStripMenuItem3,
				this.ToolStripMenuItem4,
				this.ToolStripMenuItem5,
				this.ToolStripSeparator1
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new System.Drawing.Size(129, 230);
			contextMenuStrip.Size = size;
			this.ToolStripMenuItem_0.Name = "页码ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem = this.ToolStripMenuItem_0;
			size = new System.Drawing.Size(128, 22);
			toolStripItem.Size = size;
			this.ToolStripMenuItem_0.Text = "页码";
			this.ToolStripMenuItem_1.Name = "总页数ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem2 = this.ToolStripMenuItem_1;
			size = new System.Drawing.Size(128, 22);
			toolStripItem2.Size = size;
			this.ToolStripMenuItem_1.Text = "总页数";
			this.ToolStripMenuItem_2.Name = "当前日期ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem3 = this.ToolStripMenuItem_2;
			size = new System.Drawing.Size(128, 22);
			toolStripItem3.Size = size;
			this.ToolStripMenuItem_2.Text = "当前日期";
			this.ToolStripMenuItem_2.ToolTipText = "插入当前日期，以-号分格";
			this.ToolStripMenuItem_3.Name = "当前日期2ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem4 = this.ToolStripMenuItem_3;
			size = new System.Drawing.Size(128, 22);
			toolStripItem4.Size = size;
			this.ToolStripMenuItem_3.Text = "当前日期2";
			this.ToolStripMenuItem_3.ToolTipText = "长日期格式";
			this.ToolStripMenuItem_4.Name = "当前年ToolStripMenuItem";
			System.Windows.Forms.ToolStripItem toolStripItem5 = this.ToolStripMenuItem_4;
			size = new System.Drawing.Size(128, 22);
			toolStripItem5.Size = size;
			this.ToolStripMenuItem_4.Text = "当前年";
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			System.Windows.Forms.ToolStripItem toolStripMenuItem = this.ToolStripMenuItem1;
			size = new System.Drawing.Size(128, 22);
			toolStripMenuItem.Size = size;
			this.ToolStripMenuItem1.Text = "当前月";
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			System.Windows.Forms.ToolStripItem toolStripMenuItem2 = this.ToolStripMenuItem2;
			size = new System.Drawing.Size(128, 22);
			toolStripMenuItem2.Size = size;
			this.ToolStripMenuItem2.Text = "当前日";
			this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
			System.Windows.Forms.ToolStripItem toolStripMenuItem3 = this.ToolStripMenuItem3;
			size = new System.Drawing.Size(128, 22);
			toolStripMenuItem3.Size = size;
			this.ToolStripMenuItem3.Text = "当前时间";
			this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
			System.Windows.Forms.ToolStripItem toolStripMenuItem4 = this.ToolStripMenuItem4;
			size = new System.Drawing.Size(128, 22);
			toolStripMenuItem4.Size = size;
			this.ToolStripMenuItem4.Text = "行号";
			this.ToolStripMenuItem4.ToolTipText = "表格详细数据行号，从1开始计算";
			this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
			System.Windows.Forms.ToolStripItem toolStripMenuItem5 = this.ToolStripMenuItem5;
			size = new System.Drawing.Size(128, 22);
			toolStripMenuItem5.Size = size;
			this.ToolStripMenuItem5.Text = "页行号";
			this.ToolStripMenuItem5.ToolTipText = "每页从1重新开始计算的行号";
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			System.Windows.Forms.ToolStripItem toolStripSeparator = this.ToolStripSeparator1;
			size = new System.Drawing.Size(125, 6);
			toolStripSeparator.Size = size;
			System.Windows.Forms.Control button = this.Button1;
			location = new System.Drawing.Point(17, 203);
			button.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Control button2 = this.Button1;
			size = new System.Drawing.Size(106, 23);
			button2.Size = size;
			this.Button1.TabIndex = 2;
			this.Button1.Text = "插入系统变量.…";
			this.Button1.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control button3 = this.Button2;
			location = new System.Drawing.Point(133, 203);
			button3.Location = location;
			this.Button2.Name = "Button2";
			System.Windows.Forms.Control button4 = this.Button2;
			size = new System.Drawing.Size(128, 23);
			button4.Size = size;
			this.Button2.TabIndex = 2;
			this.Button2.Text = "插入自定义变量.…";
			this.Button2.UseVisualStyleBackColor = true;
			this.ContextMenuStrip2.Name = "ContextMenuStrip2";
			System.Windows.Forms.Control contextMenuStrip2 = this.ContextMenuStrip2;
			size = new System.Drawing.Size(61, 4);
			contextMenuStrip2.Size = size;
			System.Windows.Forms.Control button5 = this.Button3;
			location = new System.Drawing.Point(17, 230);
			button5.Location = location;
			this.Button3.Name = "Button3";
			System.Windows.Forms.Control button6 = this.Button3;
			size = new System.Drawing.Size(106, 23);
			button6.Size = size;
			this.Button3.TabIndex = 2;
			this.Button3.Text = "插入字段变量.…";
			this.Button3.UseVisualStyleBackColor = true;
			this.ContextMenuStrip3.Name = "ContextMenuStrip3";
			System.Windows.Forms.Control contextMenuStrip3 = this.ContextMenuStrip3;
			size = new System.Drawing.Size(61, 4);
			contextMenuStrip3.Size = size;
			System.Windows.Forms.Control label = this.Label1;
			location = new System.Drawing.Point(10, 258);
			label.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label2 = this.Label1;
			size = new System.Drawing.Size(421, 64);
			label2.Size = size;
			this.Label1.TabIndex = 3;
			this.Label1.Text = "注1：在表达式中可进行加、减、乘、除运算及带括号的运算（如果有系统变量、自定义变量及字段变量，则会先把变量替换为相应的值后再进行计算），还可以使用大部分.NET自身的函数及自定义函数（请参见帮助文件）。但请注意，如果使用了除 加、减、乘、除运算及带括号的运算外的其他运算及涉及到函数，程序将用动态编译的办法来求表达式的值，此时速度会比较慢。";
			System.Windows.Forms.Control label3 = this.Label2;
			location = new System.Drawing.Point(14, 327);
			label3.Location = location;
			this.Label2.Name = "Label2";
			System.Windows.Forms.Control label4 = this.Label2;
			size = new System.Drawing.Size(413, 25);
			label4.Size = size;
			this.Label2.TabIndex = 3;
			this.Label2.Text = "注2：如果不同类型的变量名称存在相同的情况 ，则程序替换变量的顺序是：先字段变量，再自定义变量，最后才是系统变量。";
			System.Windows.Forms.Control label5 = this.Label3;
			location = new System.Drawing.Point(14, 362);
			label5.Location = location;
			this.Label3.Name = "Label3";
			System.Windows.Forms.Control label6 = this.Label3;
			size = new System.Drawing.Size(413, 25);
			label6.Size = size;
			this.Label3.TabIndex = 3;
			this.Label3.Text = "注3：如果表达式不合法，则不会进行计算，而是直接显示文本（设计时不会检测表达式的合法性）。";
			this.AcceptButton = this.OK_Button;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_Button;
			size = new System.Drawing.Size(443, 392);
			this.ClientSize = size;
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.TableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TextEdit_Express";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "表达式编辑器";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x04000551 RID: 1361
		private System.ComponentModel.IContainer components;
	}
}
