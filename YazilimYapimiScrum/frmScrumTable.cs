using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimYapimiScrum
{
    public partial class frmScrumTable : Form
    {
        public Kopru kopru;
        public frmHikaye hikaye;
        public frmGorev gorev;
        public DateTime dateTime { get; set; }
        public List<Button> Gorevler;


        public frmScrumTable()
        {
            Gorevler = new List<Button>();
            kopru = new Kopru();
            hikaye = new frmHikaye();
            gorev = new frmGorev();
            InitializeComponent();
            pnlToDo.AllowDrop = true;
            pnlInp.AllowDrop = true;
            pnlDone.AllowDrop = true;

        }

        public void ButtonControl()
        {
            for (int i = 0; i < Gorevler.Count(); i++)
            {
                for (int j = i+1; j < Gorevler.Count(); j++)
                {
                    if (Gorevler[i].Text == Gorevler[j].Text)
                        pnlToDo.Controls.Remove(Gorevler[i]);

                }
            }
        }

        public void HikayeVeGorevButonuOlustur()
        {
            int top = 50;
            int top2 = 50;
            
            for (int i = 0; i < kopru.Hikayeler.Count(); i++)
            {

                Button buttonStory = new Button();
                buttonStory.Text = kopru.Hikayeler[i].HikayeBaslıgı;
                buttonStory.Width = 150;
                buttonStory.Height = 100;
                buttonStory.BackColor = System.Drawing.Color.White;
                buttonStory.Left = 50;
                buttonStory.Top = top;
                top += buttonStory.Height + 2;
                pnlStory.Controls.Add(buttonStory);
                buttonStory.Click += ButtonStory_Click;

                pnlToDo.DragEnter += PnlToDo_DragEnter;
                pnlInp.DragEnter += PnlInp_DragEnter;
                pnlDone.DragEnter += PnlDone_DragEnter;

                pnlToDo.DragDrop += PnlToDo_DragDrop;
                pnlInp.DragDrop += PnlInp_DragDrop;
                pnlDone.DragDrop += PnlDone_DragDrop;

                



                for (int j = 0; j < kopru.Hikayeler[i].GorevYolculugu.Count(); j++)
                {
                    Button buttonTask = new Button();
                    buttonTask.Text = kopru.Hikayeler[i].GorevYolculugu[j].GorevBaslıgı;
                    buttonTask.Width = 120;
                    buttonTask.Height = (buttonStory.Height / kopru.Hikayeler[i].GorevYolculugu.Count());
                    buttonTask.BackColor = System.Drawing.Color.White;
                    buttonTask.Left = 60;
                    buttonTask.Top = top2;
                    pnlToDo.Controls.Add(buttonTask);
                    top2 += buttonTask.Height;
                    buttonTask.Click += ButtonTask_Click;
                    buttonTask.MouseDown += ButtonTask_MouseDown;
                    Gorevler.Add(buttonTask);
                    

                }

            }
        }

        private void ButtonTask_MouseDown(object sender, MouseEventArgs e)
        {
            Button button2= (Button)sender;
            button2.DoDragDrop(button2, DragDropEffects.Move);

            if (pnlDone.Controls.Contains(button2))
            {
                for (int i = 0; i < kopru.Hikayeler.Count(); i++)
                {
                    for (int j = 0; j < kopru.Hikayeler[i].GorevYolculugu.Count(); j++)
                    {
                        if (button2.Text == kopru.Hikayeler[i].GorevYolculugu[j].GorevBaslıgı)
                        {
                            kopru.Hikayeler[i].GorevYolculugu[j].BitisTarihi = DateTime.Now;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < kopru.Hikayeler.Count(); i++)
                {
                    for (int j = 0; j < kopru.Hikayeler[i].GorevYolculugu.Count(); j++)
                    {
                        if (button2.Text == kopru.Hikayeler[i].GorevYolculugu[j].GorevBaslıgı)
                        {
                            kopru.Hikayeler[i].GorevYolculugu[j].BitisTarihi = dateTime;
                        }
                    }
                }
                
            }

            button2.PerformClick();
            
        }

        private void PnlDone_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }

        private void PnlInp_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }

        private void PnlToDo_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }

        private void PnlDone_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PnlInp_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PnlToDo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }


        private void ButtonTask_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string temp = "";
            for (int j = 0; j < kopru.Hikayeler.Count(); j++)
            {
                for (int i = 0; i < kopru.Hikayeler[j].GorevYolculugu.Count(); i++)
                {
                   
              if (b.Text == kopru.Hikayeler[j].GorevYolculugu[i].GorevBaslıgı)
                {

                    temp += "Görev Başlığı = " + kopru.Hikayeler[j].GorevYolculugu[i].GorevBaslıgı + Environment.NewLine + "Görevli = " + kopru.Hikayeler[j].GorevYolculugu[i].Gorevli +
                            Environment.NewLine +"Görev Başlama Tarihi = " + kopru.Hikayeler[j].GorevYolculugu[i].BaslangıcTarihi+Environment.NewLine+
                            "Son Teslim Tarihi = " + kopru.Hikayeler[j].GorevYolculugu[i].SonTeslimTarihi+Environment.NewLine +"Bitirme Tarihi = "+ kopru.Hikayeler[j].GorevYolculugu[i].BitisTarihi+
                            Environment.NewLine+"Görev Açıklaması = " + kopru.Hikayeler[j].GorevYolculugu[i].Acıklama;

                    break;
                }

                }
  

            }

            MessageBox.Show(temp);

        }

        private void ButtonStory_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            string temp = "";
                for (int j = 0; j < kopru.Hikayeler.Count(); j++)
                {

                    if (b.Text == kopru.Hikayeler[j].HikayeBaslıgı)
                    {
                        temp += "Hikaye Başlığı = " + kopru.Hikayeler[j].HikayeBaslıgı + Environment.NewLine + "Hikaye Yazarı = " + kopru.Hikayeler[j].HikayeYazari + Environment.NewLine +
                                "Hikaye Oluşturma Tarihi = " + kopru.Hikayeler[j].OlusturmaTarihi + Environment.NewLine + "Hikaye Açıklaması = " + kopru.Hikayeler[j].HikayeAciklamasi;

                        break;
                    }
                    
                }

            MessageBox.Show(temp);
        }


        public void Closer()
        {
            hikaye.Close();
            gorev.Close();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pnlStory.Visible = false;
            pnlToDo.Visible = false;
            pnlInp.Visible = false;
            pnlDone.Visible = false;
            lblStory.Visible = false;
            lblToDo.Visible = false;
            lblInp.Visible = false;
            lblDone.Visible = false;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            hikaye.Close();
            gorev.Close();
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pnlStory.Visible = true;
            pnlToDo.Visible = true;
            pnlInp.Visible = true;
            pnlDone.Visible = true;
            lblStory.Visible = true;
            lblToDo.Visible = true;
            lblInp.Visible = true;
            lblDone.Visible = true;

            
            pnlToDo.Controls.Clear();
            HikayeVeGorevButonuOlustur();
            ButtonControl();

            if (pnlToDo.Visible==true)
            {
                btnGoster.Enabled = false;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Closer();
        }

        private void btnAddStory_Click(object sender, EventArgs e)
        {
            Closer();
            hikaye = new frmHikaye();
            hikaye.MdiParent = this;
            hikaye.kopru = this.kopru;
            hikaye.Show();
            hikaye.BringToFront();
            hikaye.WindowState = FormWindowState.Maximized;
            btnGoster.Enabled = true;


        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Closer();
            gorev = new frmGorev();
            gorev.MdiParent = this;
            gorev.kopru = this.kopru;
            gorev.Show();
            gorev.BringToFront();
            gorev.WindowState = FormWindowState.Maximized;
            btnGoster.Enabled = true;
        }
    }
}
