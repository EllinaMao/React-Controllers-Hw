using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using React_Controllers_Hw.Models;

namespace React_Controllers_Hw.Controllers
{
    /*
     * Разработайте веб-приложение для онлайн-курсов. Создайте страницу, на которой пользователи могут просмотреть список доступных курсов и подписываться на них. Ваша задача состоит в том, чтобы создать контроллер, который будет отображать список курсов и обрабатывать запросы на подписку.

     */
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
