using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Room : IEntity
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public string RoomCapacity { get; set; }
        public string Active { get; set; }
        public bool Status { get; set; }
    }
}
