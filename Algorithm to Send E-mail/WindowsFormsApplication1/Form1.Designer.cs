namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kime";
            // 
            // txtKime
            // 
            this.txtKime.Location = new System.Drawing.Point(93, 25);
            this.txtKime.Name = "txtKime";
            this.txtKime.Size = new System.Drawing.Size(215, 20);
            this.txtKime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Konu";
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(93, 64);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(215, 20);
            this.txtKonu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mesaj";
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(93, 100);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(215, 140);
            this.txtMesaj.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "GÖNDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(93, 301);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 331);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSonuc;
    }
}

