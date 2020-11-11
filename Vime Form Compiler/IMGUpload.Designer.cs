namespace Vime_Form_Compiler
{
    partial class IMGUpload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UploadingTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UploadingTextBox
            // 
            this.UploadingTextBox.AllowDrop = true;
            this.UploadingTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UploadingTextBox.Location = new System.Drawing.Point(2, 12);
            this.UploadingTextBox.Multiline = true;
            this.UploadingTextBox.Name = "UploadingTextBox";
            this.UploadingTextBox.ReadOnly = true;
            this.UploadingTextBox.Size = new System.Drawing.Size(310, 174);
            this.UploadingTextBox.TabIndex = 0;
            this.UploadingTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.UploadingTextBox_DragDrop);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Скопировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IMGUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 226);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UploadingTextBox);
            this.Name = "IMGUpload";
            this.Text = "IMGUpload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UploadingTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}