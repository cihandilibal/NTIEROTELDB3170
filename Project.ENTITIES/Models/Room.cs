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

        public void Tutar()
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

        }
    }
}
