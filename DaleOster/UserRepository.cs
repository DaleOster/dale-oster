using DaleOster.Models;
using Dapper;
using System.Data;

namespace DaleOster
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _connection;
        
        public UserRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<User> GetShipCaptainAndCrewLeaders()
        {
            return _connection.Query<User>("SELECT * FROM Users INNER JOIN ShipCaptainAndCrew ON Users.Username = ShipCaptainAndCrew.Username");
        }
    }
}