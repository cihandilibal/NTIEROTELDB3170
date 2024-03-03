using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomType: BaseEntity
    {
        public string TypeName { get; set; }
        public decimal Price { get; set; }
        public virtual List<Room> Rooms { get; set; }


    }
}
