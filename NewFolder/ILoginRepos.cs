using KTI_Testing__Mobile_.Models;

namespace KTI_Testing__Mobile_.NewFolder
{
    public interface ILoginRepos
    {
        Task<UserInfo> Login(string username, string password);
    }
}
