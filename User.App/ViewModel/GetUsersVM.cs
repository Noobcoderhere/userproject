using System.Collections.Generic;
using User.Domain.Model;

namespace User.App.ViewModel
{
    public class GetUsersVM
    {
        public IEnumerable<TestUser> Users { get; set; }
    }
}
