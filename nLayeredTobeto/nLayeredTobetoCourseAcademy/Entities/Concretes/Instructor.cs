using Core.Entities;

namespace Entities.Concretes
{
    public class Instructor : Entity<Guid>
    {
        public List<Course> Courses { get; set; }
        public string Name { get; set; }
    }
}