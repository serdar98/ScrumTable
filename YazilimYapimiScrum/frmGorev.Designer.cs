namespace YazilimYapimiScrum
{
    partial class frmGorev
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
            this.btnGorevOlustur = new System.Windows.Forms.Button();
            this.txtAcıklama = new System.Windows.Forms.TextBox();
            this.txtGorevli = new System.Windows.Forms.TextBox();
            this.txtHikayeBaslıgı = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbHikaye = new System.Windows.Forms.ComboBox();
            this.lblcmbx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFD = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnGorevOlustur
            // 
            this.btnGorevOlustur.Location = new System.Drawing.Point(387, 412);
            this.btnGorevOlustur.Name = "btnGorevOlustur";
            this.btnGorevOlustur.Size = new System.Drawing.Size(297, 35);
            this.btnGorevOlustur.TabIndex = 13;
            this.btnGorevOlustur.Text = "Görev Oluştur";
            this.btnGorevOlustur.UseVisualStyleBackColor = true;
            this.btnGorevOlustur.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // txtAcıklama
            // 
            this.txtAcıklama.Location = new System.Drawing.Point(387, 250);
            this.txtAcıklama.Multiline = true;
            this.txtAcıklama.Name = "txtAcıklama";
            this.txtAcıklama.Size = new System.Drawing.Size(297, 156);
            this.txtAcıklama.TabIndex = 12;
            // 
            // txtGorevli
            // 
            this.txtGorevli.Location = new System.Drawing.Point(443, 169);
            this.txtGorevli.Multiline = true;
            this.txtGorevli.Name = "txtGorevli";
            this.txtGorevli.Size = new System.Drawing.Size(178, 32);
            this.txtGorevli.TabIndex = 11;
            // 
            // txtHikayeBaslıgı
            // 
            this.txtHikayeBaslıgı.Location = new System.Drawing.Point(443, 124);
            this.txtHikayeBaslıgı.Multiline = true;
            this.txtHikayeBaslıgı.Name = "txtHikayeBaslıgı";
            this.txtHikayeBaslıgı.Size = new System.Drawing.Size(178, 30);
            this.txtHikayeBaslıgı.TabIndex = 10;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(307, 313);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(50, 13);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.Text = "Açıklama";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(307, 172);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(40, 13);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Görevli";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(307, 127);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(73, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Hikaye Başlığı";
            // 
            // cbHikaye
            // 
            this.cbHikaye.FormattingEnabled = true;
            this.cbHikaye.Location = new System.Drawing.Point(443, 77);
            this.cbHikaye.Name = "cbHikaye";
            this.cbHikaye.Size = new System.Drawing.Size(178, 21);
            this.cbHikaye.TabIndex = 14;
            // 
            // lblcmbx
            // 
            this.lblcmbx.AutoSize = true;
            this.lblcmbx.Location = new System.Drawing.Point(307, 80);
            this.lblcmbx.Name = "lblcmbx";
            this.lblcmbx.Size = new System.Drawing.Size(62, 13);
            this.lblcmbx.TabIndex = 15;
            this.lblcmbx.Text = "Hikaye Seç";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "TeslimTarihi";
            // 
            // dtpFD
            // 
            this.dtpFD.Location = new System.Drawing.Point(443, 217);
            this.dtpFD.Name = "dtpFD";
            this.dtpFD.Size = new System.Drawing.Size(178, 20);
            this.dtpFD.TabIndex = 17;
            // 
            // frmGorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(725, 459);
            this.Controls.Add(this.dtpFD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcmbx);
            this.Controls.Add(this.cbHikaye);
            this.Controls.Add(this.btnGorevOlustur);
            this.Controls.Add(this.txtAcıklama);
            this.Controls.Add(this.txtGorevli);
            this.Controls.Add(this.txtHikayeBaslıgı);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGorev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGorevOlustur;
        private System.Windows.Forms.TextBox txtAcıklama;
        private System.Windows.Forms.TextBox txtGorevli;
        private System.Windows.Forms.TextBox txtHikayeBaslıgı;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbHikaye;
        private System.Windows.Forms.Label lblcmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFD;
    }
}