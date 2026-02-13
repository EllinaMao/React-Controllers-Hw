namespace React_Controllers_Hw.Models.Courses
{
    public class CourceRepository:ICourceRepository
    {
        private List<Cource> cources_ = new List<Cource>
        {
            new Cource {Title = "C# for Beginners", Description = "Learn the basics of C# programming language." },
            new Cource {Title = "ASP.NET Core Web API", Description = "Build RESTful APIs using ASP.NET Core." },
            new Cource {Title = "Entity Framework Core", Description = "Master data access with Entity Framework Core." },
            new Cource {Title = "React for .NET Developers", Description = "Learn how to integrate React with .NET applications." }
        };

        public IEnumerable<Cource> GetAllCources()
        {
            return new List<Cource>(cources_);
        }
        public Cource? GetCource(Guid id)
        {
            return cources_.FirstOrDefault(c => c.Id == id);
        }
        public void AddCource(Cource cource)
        {
            cources_.Add(cource);
        }
        public IEnumerable<Cource> GetSubscribedCources(IEnumerable<Guid> subscribedCourseIds)
        {
            return cources_.Where(c => subscribedCourseIds.Contains(c.Id)).ToList();
        }

    }
}
