namespace LuoEasyPrint
{

	public partial class ChooseExcelSheet : Form
	{
		// Token: 0x06001C98 RID: 7320 RVA: 0x000E1438 File Offset: 0x000DF638
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

		// Token: 0x06001C99 RID: 7321 RVA: 0x000E1478 File Offset: 0x000DF678
		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(ChooseExcelSheet));
			this.Button1 = new System.Windows.Forms.Button();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			System.Windows.Forms.Control button = this.Button1;
			System.Drawing.Point location = new System.Drawing.Point(44, 110);
			button.Location = location;
			this.Button1.Name = "Button1";
			System.Windows.Forms.Control button2 = this.Button1;
			System.Drawing.Size size = new System.Drawing.Size(75, 23);
			button2.Size = size;
			this.Button1.TabIndex = 0;
			this.Button1.Text = "确定";
			this.Button1.UseVisualStyleBackColor = true;
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.FormattingEnabled = true;
			System.Windows.Forms.Control comboBox = this.ComboBox1;
			location = new System.Drawing.Point(14, 59);
			comboBox.Location = location;
			this.ComboBox1.Name = "ComboBox1";
			System.Windows.Forms.Control comboBox2 = this.ComboBox1;
			size = new System.Drawing.Size(265, 20);
			comboBox2.Size = size;
			this.ComboBox1.TabIndex = 1;
			System.Windows.Forms.Control label = this.Label1;
			location = new System.Drawing.Point(12, 9);
			label.Location = location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Control label2 = this.Label1;
			size = new System.Drawing.Size(267, 35);
			label2.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "选择的Excel文件中存在多个工作表，请选择要导入数据的Excel工作表：";
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			System.Windows.Forms.Control button3 = this.Button2;
			location = new System.Drawing.Point(141, 110);
			button3.Location = location;
			this.Button2.Name = "Button2";
			System.Windows.Forms.Control button4 = this.Button2;
			size = new System.Drawing.Size(75, 23);
			button4.Size = size;
			this.Button2.TabIndex = 0;
			this.Button2.Text = "取消";
			this.Button2.UseVisualStyleBackColor = true;
			this.AcceptButton = this.Button1;
			System.Drawing.SizeF autoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Button2;
			size = new System.Drawing.Size(288, 141);
			this.ClientSize = size;
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChooseExcelSheet";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "选择要导入的Excel工作表";
			this.ResumeLayout(false);
		}

		// Token: 0x04000E17 RID: 3607
		private System.ComponentModel.IContainer components;
	}
}
