using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Oda : BaseEntity
    {
        public string OdaNo { get; set; }

        public OdaTipi OdaTipi { get; set; }
        public int Fiyat { get; set; }

        // Realational Properties

        public virtual List<OdaRezervasyonu> RoomReservations { get; set; }

        public void Tutar()
        {
            Fiyat = 0;
            switch (OdaTipi)
            {
                case OdaTipi.TekKisilik:
                    Fiyat += 200;
                    break;
                case OdaTipi.IkiKisilik:
                    Fiyat += 400;
                    break;
                case OdaTipi.UcKisilik:
                    Fiyat += 600;
                    break;
                case OdaTipi.Suit:
                    Fiyat += 750;
                    break;
                case OdaTipi.AileOdasi:
                    Fiyat += 800;
                    break;
            }

        }
    }
}
