using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimiScrum
{
   public class Kopru
    {
        public List<Hikaye> Hikayeler = new List<Hikaye>();


        public void HikayeOlustur(Hikaye hikaye)
        {
            Hikayeler.Add(hikaye);
        }

    }
}
