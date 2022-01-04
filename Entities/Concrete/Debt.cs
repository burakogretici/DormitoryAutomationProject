using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Debt : IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int RemainingDebt { get; set; }
        public bool Status { get; set; }
    }
}
