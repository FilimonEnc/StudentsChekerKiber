namespace StudentsChekerKiber.Model
{
    public class ParentModel : BaseModel
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string? MiddleName { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public StudentModel Student { get; set; } = null!;
    }
}
