using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class City : IEntity
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string CityName { get; set; }
        public bool Status { get; set; }
    }
}
