using MayBatch1AspCoreApp.Models;

namespace MayBatch1AspCoreApp.Repo
{
    public interface UserRepo
    {
        void SignUp(User us);
        //void SignIn(Login log);
    }
}