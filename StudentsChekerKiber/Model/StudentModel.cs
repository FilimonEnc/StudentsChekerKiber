using StudentsChekerKiber.Data.Entity;
using System.Collections.Generic;

namespace StudentsChekerKiber.Model
{
    public class StudentModel : BaseModel
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string? MiddleName { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; }

        public int Age { get; set; }

        public List<ParentModel>? Parents { get; set; }
    }
}
