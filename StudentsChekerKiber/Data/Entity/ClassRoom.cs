using System.Collections.Generic;

namespace StudentsChekerKiber.Data.Entity
{
    public class ClassRoom : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public List<Food>? Foods { get; set; }
    }
}
