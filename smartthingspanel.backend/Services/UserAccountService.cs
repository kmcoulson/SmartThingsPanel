using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using smartthingspanel.backend.Data;
using smartthingspanel.backend.Models.Documents;

namespace smartthingspanel.backend.Services
{
    public class UserAccountService
    {
        private readonly MongoRepository<UserAccount> _repository;

        public UserAccountService(MongoRepository<UserAccount> repository)
        {
            _repository = repository;
        }
        public UserAccountService() : this(new MongoRepository<UserAccount>()) { }

        public UserAccount Add(string name, string username, string password)
        {
            var newUser = new UserAccount
            {
                Id = Guid.NewGuid(),
                Token = Guid.NewGuid(),
                Name = name, 
                Username = username,
                Salt = Guid.NewGuid().ToString()
            };
            newUser.Password = GenerateSaltedHash(password, newUser.Salt);

            _repository.InsertOrOverwrite(newUser);
            return newUser;
        }


        public Guid Authenticate(string username, string password)
        {
            var userResults = _repository.Find(x => x.Username == username);
            if (!userResults.Any()) return Guid.Empty;
            var user = userResults.First();
            return GenerateSaltedHash(password, user.Salt) == user.Password ? user.Token : Guid.Empty;
        }

        private static string GenerateSaltedHash(string password, string salt)
        {
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            var saltBytes = Encoding.UTF8.GetBytes(salt);

            var saltedValue = passwordBytes.Concat(saltBytes).ToArray();
            var saltedHash = new SHA256Managed().ComputeHash(saltedValue);
            return Convert.ToBase64String(saltedHash);
        }
    }
}