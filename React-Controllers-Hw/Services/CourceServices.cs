using React_Controllers_Hw.Models.Courses;

namespace React_Controllers_Hw.Services
{
    public class CourceServices
    {
        private readonly ICourceRepository _repository;
        private readonly HashSet<(Guid CourseId, Guid UserId)> _subscriptions = new();

        public CourceServices(ICourceRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Cource> GetAllCources()
        {
            return _repository.GetAllCources();
        }
        public bool IsSubscribed(Guid courseId, Guid userId)
        {
            return _subscriptions.Contains((courseId, userId));
        }
        public void Subscribe(Guid courseId, Guid userId)
        {
            var course = _repository.GetCource(courseId);
            if (course != null)
            {
                _subscriptions.Add((courseId, userId));
            }
        }
         public void Unsubscribe(Guid courseId, Guid userId)
        {
            var course = _repository.GetCource(courseId);
            if (course != null)
            {
                _subscriptions.Remove((courseId, userId));
            }
        }

    }
}
