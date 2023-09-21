using System;

namespace StudentsChekerKiber.Data.Entity
{
    public class Food : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public int Amount { get; set; } = 0;

        public bool StatusDelete { get; set; } = false;

        public ClassRoom ClassRoom
        {
            get => _classRoom ?? throw new InvalidOperationException("Uninitialized property: " + nameof(ClassRoom));
            set => _classRoom = value;
        }
        private ClassRoom? _classRoom;
    }
}
