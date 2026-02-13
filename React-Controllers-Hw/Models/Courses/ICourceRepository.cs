namespace React_Controllers_Hw.Models.Courses
{
    public interface ICourceRepository
    {
        public IEnumerable<Cource> GetAllCources();
        public Cource? GetCource(Guid courceId);
        public IEnumerable<Cource> GetSubscribedCources(IEnumerable<Guid> subscribedCourseIds);
        public void AddCource(Cource cource);

    }
}
