namespace WindowsForms
{
	partial class WinForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox = new System.Windows.Forms.TextBox();
			this.openFileButton = new System.Windows.Forms.Button();
			this.openFolderButton = new System.Windows.Forms.Button();
			this.copyButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox.Location = new System.Drawing.Point(12, 12);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.ReadOnly = true;
			this.textBox.Size = new System.Drawing.Size(372, 123);
			this.textBox.TabIndex = 0;
			// 
			// openFileButton
			// 
			this.openFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.openFileButton.Location = new System.Drawing.Point(12, 141);
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.Size = new System.Drawing.Size(120, 40);
			this.openFileButton.TabIndex = 1;
			this.openFileButton.Text = "Open file";
			this.openFileButton.UseVisualStyleBackColor = true;
			this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
			// 
			// openFolderButton
			// 
			this.openFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.openFolderButton.Location = new System.Drawing.Point(138, 141);
			this.openFolderButton.Name = "openFolderButton";
			this.openFolderButton.Size = new System.Drawing.Size(120, 40);
			this.openFolderButton.TabIndex = 2;
			this.openFolderButton.Text = "Open file in folder";
			this.openFolderButton.UseVisualStyleBackColor = true;
			this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
			// 
			// copyButton
			// 
			this.copyButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.copyButton.Location = new System.Drawing.Point(264, 141);
			this.copyButton.Name = "copyButton";
			this.copyButton.Size = new System.Drawing.Size(120, 40);
			this.copyButton.TabIndex = 3;
			this.copyButton.Text = "Copy to clipboard";
			this.copyButton.UseVisualStyleBackColor = true;
			this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// WinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 193);
			this.Controls.Add(this.copyButton);
			this.Controls.Add(this.openFolderButton);
			this.Controls.Add(this.openFileButton);
			this.Controls.Add(this.textBox);
			this.MaximizeBox = false;
			this.Name = "WinForm";
			this.ShowIcon = false;
			this.Text = "TomskNIPIneft";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.Button openFolderButton;
		private System.Windows.Forms.Button copyButton;
	}
}

