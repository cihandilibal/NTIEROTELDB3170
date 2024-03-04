using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class OdaRezervasyonu: BaseEntity
    {
        public int OdaID { get; set; }
        public int RezervasyonID { get; set; }

        // Realational Properties
        public virtual Oda Oda { get; set; }
        public virtual Rezervasyon Rezervasyon { get; set; }

    }
}
