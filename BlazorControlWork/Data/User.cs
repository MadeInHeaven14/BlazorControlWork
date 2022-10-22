using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BlazorControlWork.Data
{
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        //public User (string name, string surname, string login, string password, string email)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Login = login;
        //    Password = password;
        //    Email = email;
        //}
    }
}
