namespace Vime_Form_Compiler
{
    partial class Staffgui
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
            this.staffTB = new System.Windows.Forms.TextBox();
            this.updatebutt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staffTB
            // 
            this.staffTB.Location = new System.Drawing.Point(12, 12);
            this.staffTB.Multiline = true;
            this.staffTB.Name = "staffTB";
            this.staffTB.ReadOnly = true;
            this.staffTB.Size = new System.Drawing.Size(189, 276);
            this.staffTB.TabIndex = 0;
            // 
            // updatebutt
            // 
            this.updatebutt.Location = new System.Drawing.Point(12, 294);
            this.updatebutt.Name = "updatebutt";
            this.updatebutt.Size = new System.Drawing.Size(189, 23);
            this.updatebutt.TabIndex = 1;
            this.updatebutt.Text = "Обновить";
            this.updatebutt.UseVisualStyleBackColor = true;
            // 
            // staffgui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 325);
            this.Controls.Add(this.updatebutt);
            this.Controls.Add(this.staffTB);
            this.Name = "staffgui";
            this.Text = "Модераторы";
            this.Load += new System.EventHandler(this.staffgui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox staffTB;
        private System.Windows.Forms.Button updatebutt;
    }
}