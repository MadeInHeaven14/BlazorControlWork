using MongoDB.Driver;

namespace BlazorControlWork.Data
{
    public class MongoExamples
    {
        public static void AddToDataBase(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersDB");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);
        }

        public static void FindByName(string login, string password)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersDB");
            var collection = database.GetCollection<User>("Users");
            var MyUser = collection.Find(x => x.Login == login).FirstOrDefault();
            if (MyUser != null)
            {
                if (MyUser.Password == password)
                {

                }
            }

        }

        public static void ReplaceByName(string name, User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UsersDB");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Name == name, user);

        }
    }
}
