using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomMaid: BaseEntity
    {
        public int RoomID { get; set; }
        public int MaidID { get; set; }
        public virtual Room Room { get; set; }
        public virtual Maid Maid { get; set; }

    }
}
