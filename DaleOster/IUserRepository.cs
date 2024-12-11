using DaleOster.Models;

namespace DaleOster
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetShipCaptainAndCrewLeaders();
    }
}
