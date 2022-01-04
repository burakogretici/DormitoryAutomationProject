using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class District : IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string DistrictName { get; set; }
        public bool Bit { get; set; }
    }
}
