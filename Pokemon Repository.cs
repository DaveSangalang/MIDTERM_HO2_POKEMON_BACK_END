using Microsoft.AspNetCore.Mvc;

namespace MIDTERM_HO2_POKEMON_BACK_END.Pages
{
    public class Pokemon_Repository : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
