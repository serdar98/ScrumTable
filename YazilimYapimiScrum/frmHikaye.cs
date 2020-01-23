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
    public partial class frmHikaye : Form
    {
        
        public Kopru kopru;

        public frmHikaye()
        {
            InitializeComponent();
        }

        private void btnCreateStory_Click(object sender, EventArgs e)
        {
            Hikaye h = new Hikaye();
            h.HikayeBaslıgı= txtHikayeBaslıgı.Text;
            h.HikayeYazari = txtYazar.Text;
            h.HikayeAciklamasi = txtAcıklama.Text;
            h.OlusturmaTarihi= DateTime.Now;
            kopru.HikayeOlustur(h);

            MessageBox.Show("Hikaye başarıyla eklendi.");
        }
    }
}
