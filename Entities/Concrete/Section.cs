using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Section : IEntity
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public string SectionName { get; set; }
        public bool Status { get; set; }
    }
}
