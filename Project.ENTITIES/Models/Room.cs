using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Room : BaseEntity
    {
        public string RoomNo { get; set; }

        public RoomTypes RoomTypes { get; set; }
        public int Price { get; set; }

        // Relational Properties

        public virtual List<RoomReservation> RoomReservations { get; set; }

        

        
    }
}
