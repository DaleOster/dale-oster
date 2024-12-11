using Microsoft.AspNetCore.Mvc;

namespace DaleOster.Controllers
{
    public class GamesController : Controller
    {
        private readonly IUserRepository repo;

        public GamesController(IUserRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShipCaptainAndCrew()
        {
            var users = repo.GetShipCaptainAndCrewLeaders();
            return View(users);
        }
    }
}
