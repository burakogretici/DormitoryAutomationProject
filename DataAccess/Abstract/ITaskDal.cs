using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Abstract;
using Entities.Concrete;
using Task = Entities.Concrete.Task;

namespace DataAccess.Abstract
{
    public interface ITaskDal : IEntityRepository<Task>
    {
    }
}
