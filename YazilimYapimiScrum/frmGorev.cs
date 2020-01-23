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
    public partial class frmGorev : Form
    {

        public Kopru kopru;

        public frmGorev()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < kopru.Hikayeler.Count(); i++)
            {
                cbHikaye.Items.Add(kopru.Hikayeler[i].HikayeBaslıgı.ToString());
            }
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kopru.Hikayeler.Count(); i++)
            {
                if (kopru.Hikayeler[i].HikayeBaslıgı==cbHikaye.SelectedItem.ToString())
                {
                    Gorev g = new Gorev();
                    g.GorevBaslıgı = txtHikayeBaslıgı.Text;
                    g.Gorevli = txtGorevli.Text;
                    g.Acıklama = txtAcıklama.Text;
                    g.BaslangıcTarihi = DateTime.Now;
                    g.BitisTarihi = Convert.ToDateTime(dtpFD.Value);
                    kopru.Hikayeler[i].TaskOlustur(g);
                }
            }
            MessageBox.Show("Görev başarıyla eklendi.");
        }
    }
}
