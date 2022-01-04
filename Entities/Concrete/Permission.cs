using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Permission : IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime DateOfReturn { get; set; }
        public string Excuse { get; set; }
        public bool Status { get; set; }  
    }
}
