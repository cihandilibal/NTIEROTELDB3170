using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Room: BaseEntity
    {
        public string RoomNo { get; set; }
        public int? RoomTypeID { get; set; }

        public virtual RoomType RoomType { get; set; }
        public virtual List<RoomMaid> RoomMaids { get; set; }
        public virtual List<RoomReservation> RoomReservations { get; set; }


    }
}
