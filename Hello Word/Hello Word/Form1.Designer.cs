namespace Hello_Word
{
    partial class frmHelloWord
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
            this.lblHelloWord = new System.Windows.Forms.Label();
            this.btnHelloWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloWord
            // 
            this.lblHelloWord.AutoSize = true;
            this.lblHelloWord.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWord.Location = new System.Drawing.Point(28, 35);
            this.lblHelloWord.Name = "lblHelloWord";
            this.lblHelloWord.Size = new System.Drawing.Size(0, 80);
            this.lblHelloWord.TabIndex = 0;
            this.lblHelloWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHelloWord.Click += new System.EventHandler(this.Form1_Load);
            // 
            // btnHelloWord
            // 
            this.btnHelloWord.Location = new System.Drawing.Point(117, 226);
            this.btnHelloWord.Name = "btnHelloWord";
            this.btnHelloWord.Size = new System.Drawing.Size(141, 23);
            this.btnHelloWord.TabIndex = 1;
            this.btnHelloWord.Text = "Show Hello Word";
            this.btnHelloWord.UseVisualStyleBackColor = true;
            this.btnHelloWord.Click += new System.EventHandler(this.Form1_Load);
            // 
            // frmHelloWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.btnHelloWord);
            this.Controls.Add(this.lblHelloWord);
            this.Name = "frmHelloWord";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Hello Word";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWord;
        private System.Windows.Forms.Button btnHelloWord;
    }
}

