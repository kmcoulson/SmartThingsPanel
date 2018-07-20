using System;
using System.Linq;
using smartthingspanel.backend.Data;
using smartthingspanel.backend.Models.Documents;

namespace smartthingspanel.backend.Services
{
    public class UserDeviceService
    {
        private readonly MongoRepository<UserDevice> _repository;

        public UserDeviceService(MongoRepository<UserDevice> repository)
        {
            _repository = repository;
        }
        public UserDeviceService() : this(new MongoRepository<UserDevice>()) { }

        public UserDevice Get(Guid token, Guid id)
        {
            return _repository.Find(x => x.Id == id && x.Token == token).FirstOrDefault();
        }

        public void AddorUpdate(UserDevice userDevice)
        {
            _repository.InsertOrOverwrite(userDevice);
        }
    }
}