using System;

namespace StudentsChekerKiber.Model
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateUpdated { get; set; }

        public bool Status { get; set; }
    }
}
