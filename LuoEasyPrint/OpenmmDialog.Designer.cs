namespace LuoEasyPrint
{
	// Token: 0x02000079 RID: 121
	
	
	public partial class OpenmmDialog : Form
	{
		// Token: 0x060011D2 RID: 4562 RVA: 0x0008D660 File Offset: 0x0008B860
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

		// Token: 0x060011D3 RID: 4563 RVA: 0x0008D6A0 File Offset: 0x0008B8A0
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new System.Windows.Forms.Button();
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.TableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			this.TableLayoutPanel1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			System.Windows.Forms.Control tableLayoutPanel = this.TableLayoutPanel1;
			System.Drawing.Point location = new System.Drawing.Point(88, 76);
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
			this.OK_Button.TabIndex = 2;
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
			this.Cancel_Button.TabIndex = 3;
			this.Cancel_Button.Text = "取消";
			this.Label1.AutoSize = true;
			System.Windows.Forms.Control label = this.Label1;
			location = new System.Drawing.Point(4, 50);
			label.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label2 = this.Label1;
			size = new System.Drawing.Size(65, 12);
			label2.Size = size;
			this.Label1.TabIndex = 4;
			this.Label1.Text = "密    码：";
			System.Windows.Forms.Control textBox = this.TextBox1;
			location = new System.Drawing.Point(75, 47);
			textBox.Location = location;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.PasswordChar = '*';
			System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new System.Drawing.Size(155, 21);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 1;
			this.CheckBox1.AutoSize = true;
			System.Windows.Forms.Control checkBox = this.CheckBox1;
			location = new System.Drawing.Point(4, 82);
			checkBox.Location = location;
			this.CheckBox1.Name = "CheckBox1";
			System.Windows.Forms.Control checkBox2 = this.CheckBox1;
			size = new System.Drawing.Size(72, 16);
			checkBox2.Size = size;
			this.CheckBox1.TabIndex = 4;
			this.CheckBox1.Text = "显示密码";
			this.CheckBox1.UseVisualStyleBackColor = true;
			System.Windows.Forms.Control label3 = this.Label2;
			location = new System.Drawing.Point(4, 9);
			label3.Location = location;
			this.Label2.Name = "Label2";
			System.Windows.Forms.Control label4 = this.Label2;
			size = new System.Drawing.Size(226, 34);
			label4.Size = size;
			this.Label2.TabIndex = 6;
			this.Label2.Text = "Label2";
			this.AcceptButton = this.OK_Button;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_Button;
			size = new System.Drawing.Size(246, 109);
			this.ClientSize = size;
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.CheckBox1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.TableLayoutPanel1);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OpenmmDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "密码";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040008D0 RID: 2256
		private System.ComponentModel.IContainer components;
	}
}
