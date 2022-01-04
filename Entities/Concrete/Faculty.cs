using Core.Entities.Abstract;

namespace  Entities.Concrete
{
    public class Faculty: IEntity
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        
    }
}
