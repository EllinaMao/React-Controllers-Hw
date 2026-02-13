namespace React_Controllers_Hw.Models.Courses
{
    public class Cource
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
