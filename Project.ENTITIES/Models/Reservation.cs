using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Reservation: BaseEntity
    {
        public string No { get; set; }
        public DateTime Date { get; set; }
        public int PeopleNummer { get; set; }
        public int? CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<RoomReservation> RoomReservations { get; set; }

    }
}
