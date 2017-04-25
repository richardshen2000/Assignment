namespace TestForm
{
    partial class Form1
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
            this.tbxDisplayer = new System.Windows.Forms.TextBox();
            this.btnWriteBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxDisplayer
            // 
            this.tbxDisplayer.Location = new System.Drawing.Point(31, 12);
            this.tbxDisplayer.Name = "tbxDisplayer";
            this.tbxDisplayer.Size = new System.Drawing.Size(425, 22);
            this.tbxDisplayer.TabIndex = 0;
            // 
            // btnWriteBack
            // 
            this.btnWriteBack.Location = new System.Drawing.Point(125, 59);
            this.btnWriteBack.Name = "btnWriteBack";
            this.btnWriteBack.Size = new System.Drawing.Size(238, 23);
            this.btnWriteBack.TabIndex = 1;
            this.btnWriteBack.Text = "Write Back";
            this.btnWriteBack.UseVisualStyleBackColor = true;
            this.btnWriteBack.Click += new System.EventHandler(this.btnWriteBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 329);
            this.Controls.Add(this.btnWriteBack);
            this.Controls.Add(this.tbxDisplayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDisplayer;
        private System.Windows.Forms.Button btnWriteBack;
    }
}

