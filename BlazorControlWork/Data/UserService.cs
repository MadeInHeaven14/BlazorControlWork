using MongoDB.Driver;

namespace BlazorControlWork.Data
{
    public class UserService
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("UsersDB");
        static IMongoCollection<User> collection = database.GetCollection<User>("Users");
        public void Save(User user)
        {
            var MyUser = collection.Find(x => x._id == user._id).FirstOrDefault();
            if (MyUser == null)
            {
                collection.InsertOne(user);
            }
            else
            {
                
            }
        }

        public void Login(string userLogin, string password)
        {
            var MyUser = collection.Find(x => x.Login == userLogin).FirstOrDefault();
            if (MyUser != null)
            {
                if (MyUser.Password == password)
                {

                }
            }
        }
    }
}
