using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Group : IEntity
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public bool Status { get; set; }  
    }
}
