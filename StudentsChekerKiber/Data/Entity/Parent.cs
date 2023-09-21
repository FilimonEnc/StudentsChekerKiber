using System;

namespace StudentsChekerKiber.Data.Entity
{
    public class Parent : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string? MiddleName { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public bool StatusDelete { get; set; } = false;

        public int Student_Id { get; set; }

        public Student Student
        {
            get => _student ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Student));
            set => _student = value;
        }
        private Student? _student;


    }
}
