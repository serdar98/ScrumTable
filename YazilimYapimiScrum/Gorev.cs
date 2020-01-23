using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimiScrum
{
    public class Gorev
    {
        public string GorevBaslıgı { get; set; }

        public string Gorevli { get; set; }

        public string Acıklama { get; set; }

        public DateTime SonTeslimTarihi { get; set; }

        public DateTime BaslangıcTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }

        public Gorev()
        {
        
        }
    }
}
