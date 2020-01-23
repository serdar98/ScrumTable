namespace YazilimYapimiScrum
{
    partial class frmHikaye
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtHikayeBaslıgı = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtAcıklama = new System.Windows.Forms.TextBox();
            this.btnHikayeOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(321, 122);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(73, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hikaye Başlığı";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(321, 183);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(72, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Hikaye Yazarı";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(321, 232);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(50, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Açıklama";
            // 
            // txtHikayeBaslıgı
            // 
            this.txtHikayeBaslıgı.Location = new System.Drawing.Point(446, 119);
            this.txtHikayeBaslıgı.Multiline = true;
            this.txtHikayeBaslıgı.Name = "txtHikayeBaslıgı";
            this.txtHikayeBaslıgı.Size = new System.Drawing.Size(178, 30);
            this.txtHikayeBaslıgı.TabIndex = 3;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(446, 180);
            this.txtYazar.Multiline = true;
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(178, 32);
            this.txtYazar.TabIndex = 4;
            // 
            // txtAcıklama
            // 
            this.txtAcıklama.Location = new System.Drawing.Point(387, 229);
            this.txtAcıklama.Multiline = true;
            this.txtAcıklama.Name = "txtAcıklama";
            this.txtAcıklama.Size = new System.Drawing.Size(297, 156);
            this.txtAcıklama.TabIndex = 5;
            // 
            // btnHikayeOlustur
            // 
            this.btnHikayeOlustur.Location = new System.Drawing.Point(387, 391);
            this.btnHikayeOlustur.Name = "btnHikayeOlustur";
            this.btnHikayeOlustur.Size = new System.Drawing.Size(297, 35);
            this.btnHikayeOlustur.TabIndex = 6;
            this.btnHikayeOlustur.Text = "Hikaye Oluştur";
            this.btnHikayeOlustur.UseVisualStyleBackColor = true;
            this.btnHikayeOlustur.Click += new System.EventHandler(this.btnCreateStory_Click);
            // 
            // frmHikaye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(725, 459);
            this.Controls.Add(this.btnHikayeOlustur);
            this.Controls.Add(this.txtAcıklama);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtHikayeBaslıgı);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHikaye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtHikayeBaslıgı;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtAcıklama;
        private System.Windows.Forms.Button btnHikayeOlustur;
    }
}