using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete
{ 
    public class Student : User,IEntity
    {
        public int SchoolId { get; set; }
        public int FacultyId { get; set; }
        public int SectionId { get; set; }
        public int ClassId { get; set; }
        public int RoomId { get; set; }
        public int GroupId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        //public int DistrictId { get; set; }
        public string StudentNumber { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname  { get; set; }
        public string ParentPhone  { get; set; }


       
    }
}
