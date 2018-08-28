using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            using (var context = new FriendOrganizerDbContext())
            {
                return context.Friends.AsNoTracking().ToList();
            }
        }
    }
}
