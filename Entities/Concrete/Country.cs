using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Country : IEntity
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public short  PhoneCode { get; set; }
        public bool Status { get; set; }
    }
}
