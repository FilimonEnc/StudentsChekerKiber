using System;
using System.Collections.Generic;

namespace StudentsChekerKiber.Data.Entity
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string? MiddleName { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; }

        public int Age { get; set; }

        public bool StatusDelete { get; set; } = false;

        public int Group_Id { get; set; } 

        public Group Group
        {
            get => _group ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Group));
            set => _group = value;
        }
        private Group? _group;

        public List<Parent>? Parents { get; set; }
    }
}
