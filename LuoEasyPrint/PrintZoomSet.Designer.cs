namespace LuoEasyPrint
{
	// Token: 0x02000085 RID: 133
	
	
	public partial class PrintZoomSet : Form
	{
		// Token: 0x060011FB RID: 4603 RVA: 0x0008E8A4 File Offset: 0x0008CAA4
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

		// Token: 0x060011FC RID: 4604 RVA: 0x0008E8E4 File Offset: 0x0008CAE4
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new System.Windows.Forms.Button();
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			this.TableLayoutPanel1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			System.Windows.Forms.Control tableLayoutPanel = this.TableLayoutPanel1;
			System.Drawing.Point location = new System.Drawing.Point(59, 73);
			tableLayoutPanel.Location = location;
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			System.Windows.Forms.Control tableLayoutPanel2 = this.TableLayoutPanel1;
			System.Drawing.Size size = new System.Drawing.Size(146, 27);
			tableLayoutPanel2.Size = size;
			this.TableLayoutPanel1.TabIndex = 0;
			this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
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
			this.Label1.AutoSize = true;
			System.Windows.Forms.Control label = this.Label1;
			location = new System.Drawing.Point(12, 15);
			label.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label2 = this.Label1;
			size = new System.Drawing.Size(89, 12);
			label2.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "打印缩放比例：";
			System.Windows.Forms.NumericUpDown numericUpDown = this.NumericUpDown1;
			decimal num = new decimal(new int[]
			{
				20,
				0,
				0,
				0
			});
			numericUpDown.Increment = num;
			System.Windows.Forms.Control numericUpDown2 = this.NumericUpDown1;
			location = new System.Drawing.Point(107, 11);
			numericUpDown2.Location = location;
			System.Windows.Forms.NumericUpDown numericUpDown3 = this.NumericUpDown1;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			numericUpDown3.Maximum = num;
			System.Windows.Forms.NumericUpDown numericUpDown4 = this.NumericUpDown1;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			numericUpDown4.Minimum = num;
			this.NumericUpDown1.Name = "NumericUpDown1";
			System.Windows.Forms.Control numericUpDown5 = this.NumericUpDown1;
			size = new System.Drawing.Size(71, 21);
			numericUpDown5.Size = size;
			this.NumericUpDown1.TabIndex = 2;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			System.Windows.Forms.NumericUpDown numericUpDown6 = this.NumericUpDown1;
			num = new decimal(new int[]
			{
				100,
				0,
				0,
				0
			});
			numericUpDown6.Value = num;
			System.Windows.Forms.Control label3 = this.Label2;
			location = new System.Drawing.Point(2, 41);
			label3.Location = location;
			this.Label2.Name = "Label2";
			System.Windows.Forms.Control label4 = this.Label2;
			size = new System.Drawing.Size(203, 29);
			label4.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "注意：为100表示100%（即未缩放）。该值只影响实际打印，不影响显示。";
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("宋体", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			this.Label3.ForeColor = System.Drawing.Color.Fuchsia;
			System.Windows.Forms.Control label5 = this.Label3;
			location = new System.Drawing.Point(181, 13);
			label5.Location = location;
			this.Label3.Name = "Label3";
			System.Windows.Forms.Control label6 = this.Label3;
			size = new System.Drawing.Size(17, 16);
			label6.Size = size;
			this.Label3.TabIndex = 1;
			this.Label3.Text = "%";
			this.AcceptButton = this.OK_Button;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_Button;
			size = new System.Drawing.Size(217, 111);
			this.ClientSize = size;
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TableLayoutPanel1);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrintZoomSet";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "打印缩放比例设置";
			this.TableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000955 RID: 2389
		private System.ComponentModel.IContainer components;
	}
}
