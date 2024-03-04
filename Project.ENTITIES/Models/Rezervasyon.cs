using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Rezervasyon: BaseEntity
    {

        public int? AppUserID { get; set; }
        public DateTime VarisTarihi { get; set; }
        public DateTime AyrilisTarihi { get; set; }
        public int KalisSuresi { get; set; }
        public OdaTipi OdaTipi { get; set; }
        public int KisiSayisi { get; set; }
        public decimal Fiyat { get; set; }
        

        // Realational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<OdaRezervasyonu> OdaRezervasyonlari { get; set; }

        public void Payment()
        {
            Fiyat = 0;
            switch (OdaTipi)
            {
                case OdaTipi.TekKisilik:
                    Fiyat = 200;
                    break;
                case OdaTipi.IkiKisilik:
                    Fiyat = 400;
                    break;
                case OdaTipi.UcKisilik:
                    Fiyat = 600;
                    break;
                case OdaTipi.Suit:
                    Fiyat = 750;
                    break;
                case OdaTipi.AileOdasi:
                    Fiyat = 800;
                    break;
            }
            Fiyat *= KalisSuresi;
        }

    }
}
