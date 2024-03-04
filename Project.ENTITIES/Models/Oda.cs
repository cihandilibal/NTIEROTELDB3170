using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Oda: BaseEntity
    {
        public string OdaNo { get; set; }
        
        public OdaTipi OdaTipi { get; set; }
        public int Fiyat { get; set; }

        // Realational Properties

        public virtual List<OdaRezervasyonu> RoomReservations { get; set; }


    }
}
