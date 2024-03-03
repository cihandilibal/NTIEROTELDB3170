using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Maid: BaseEntity
    {
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public virtual List<RoomMaid> RoomMaids { get; set; }



    }
}
