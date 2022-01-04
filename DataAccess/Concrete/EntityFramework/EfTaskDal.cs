using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Task = Entities.Concrete.Task;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfTaskDal : EfEntityRepositoryBase<Task, YurtOtomasyonContext>, ITaskDal
    {
    }
}
