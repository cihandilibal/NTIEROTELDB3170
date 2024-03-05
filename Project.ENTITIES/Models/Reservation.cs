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
        

        // Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<RoomReservation> RoomReservations { get; set; }


        
        public void Payment()
        {
            Price = 0;

            switch (RoomTypes)
            {
                case RoomTypes.SingleRoom:
                     Price += 200;
                break;

                case RoomTypes.DoubleRoom:
                     Price += 400;
                break;

            case RoomTypes.TripleRoom:
                 Price += 600;
                 break;

            case RoomTypes.SuitRoom:
                 Price += 750;
            break;

            case RoomTypes.FamilySuitRoom:
                 Price += 800;
            break;
            }
            Price *= StayLength;

            Price *= RoomCount;
        }

    }
}
