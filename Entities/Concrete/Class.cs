using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Class : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public bool Status { get; set; } 
        
    }
}
