using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using React_Controllers_Hw.Models;
using React_Controllers_Hw.Models.Users;
using React_Controllers_Hw.Services;
using React_Controllers_Hw.ViewModels;

namespace React_Controllers_Hw.Controllers
{
    /*
     * Разработайте веб-приложение для онлайн-курсов. Создайте страницу, на которой пользователи могут просмотреть список доступных курсов и подписываться на них. Ваша задача состоит в том, чтобы создать контроллер, который будет отображать список курсов и обрабатывать запросы на подписку.

     */
    
    public class HomeController : Controller
    {
        private readonly CourceServices _service;
        private static readonly Guid CurrentUserId = Guid.Parse("C217F3EA-B781-44ED-B6CE-8A6638E4655C");
        
        public HomeController(CourceServices service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var courses = _service.GetAllCources();

            var model = courses.Select(c => new CourseViewModel
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description,
                IsSubscribed = _service.IsSubscribed(c.Id, CurrentUserId)
            }).ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Subscribe(Guid id)
        {
            if (_service.IsSubscribed(id, CurrentUserId))
            {
                _service.Unsubscribe(id, CurrentUserId);
            }
            else
            {
                _service.Subscribe(id, CurrentUserId);
            }

            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
