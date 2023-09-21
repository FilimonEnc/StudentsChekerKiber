using System.Collections.Generic;

namespace StudentsChekerKiber.Data.Entity
{
    public class Group : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public int CountLessons { get; set; }

        public bool StatusDelete { get; set; } = false;

        public List<Student>? Students { get; set; }
    }
}
