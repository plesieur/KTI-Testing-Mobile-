using KTI_Testing__Mobile_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTI_Testing__Mobile_.NewFolder
{
    public interface ILoginRepos
    {
        Task<UserInfo> Login(string username, string password);
    }
}
