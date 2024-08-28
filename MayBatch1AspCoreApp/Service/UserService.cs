using MayBatch1AspCoreApp.Data;
using MayBatch1AspCoreApp.Models;
using MayBatch1AspCoreApp.Repo;

namespace MayBatch1AspCoreApp.Service
{
    public class UserService : UserRepo
    {
        private readonly ApplicationDbContext db;
        public UserService(ApplicationDbContext db)
        {
            this.db = db;
        }



        public void SignUp(User us)
        {
            db.users.Add(us);
            db.SaveChanges();
        }
    }
}