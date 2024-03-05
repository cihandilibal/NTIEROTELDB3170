using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Reservation: BaseEntity
    {

        public int? AppUserID { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int StayLength { get; set; }
        public RoomTypes RoomTypes { get; set; }
        public int RoomCount { get; set; }
        public int CustomerCount { get; set; }
        public decimal Price { get; set; }
        

        // Realational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<RoomReservation> RoomReservations { get; set; }

        public void Payment()
        {
            Price = 0;
          
            Price *= StayLength;
            Price *= RoomCount;
        }

    }
}
