using System.Collections.Generic;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            yield return new Friend {FirstName = "Roberto", LastName = "Baldin"};
            yield return new Friend { FirstName = "Bernardo", LastName = "Stefano" };
            yield return new Friend { FirstName = "Radovan", LastName = "Slovak" };
            yield return new Friend { FirstName = "Anca", LastName = "Roma" };
        }
    }
}
