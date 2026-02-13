namespace React_Controllers_Hw.Models.Users
{
    public class User
    {
        public int Id = 1;
        public List<Guid> SubscribedCourseIds { get; set; } = new List<Guid>();
    }
}
