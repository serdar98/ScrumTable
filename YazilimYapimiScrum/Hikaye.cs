using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimiScrum
{
   public class Hikaye
    {
        public List<Gorev> GorevYolculugu = new List<Gorev>();

        public string HikayeBaslıgı { get; set; }

        public string HikayeYazari { get; set; }

        public string HikayeAciklamasi { get; set; }

        public DateTime OlusturmaTarihi { get; set; }
        public object TaskJourney { get; internal set; }

        public Hikaye()
        {

        }

        public void TaskOlustur(Gorev task)
        {
            GorevYolculugu.Add(task);
        }

    }
}
