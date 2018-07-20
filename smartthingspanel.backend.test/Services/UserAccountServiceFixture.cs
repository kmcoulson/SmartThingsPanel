using NUnit.Framework;
using NUnit.Framework.Internal;
using smartthingspanel.backend.Services;

namespace smartthingspanel.backend.test.Services
{
    [TestFixture]
    public class UserAccountServiceFixture
    {
        private UserAccountService _userAccountService;

        [SetUp]
        public void Setup()
        {
            _userAccountService = new UserAccountService();
        }

        [Test]
        public void CreateAccount()
        {
            _userAccountService.Add("Kevin Coulson", "kmcoulson", "Syren134");
            Assert.True(true);
        }
    }
}
