using Atata;
using Bogus.Extensions;
using DAFT.Framework.Data;
using NUnit.Framework;
using DAFT.Framework.Tests;
using TheInternet.Pages.Core;

namespace TheInternet
{
    public class Tests : BaseTest
    {
        [Test]
        public void Login()
        {
            var login = new Login
            {
                Username = "tomsmith",
                Password = "SuperSecretPassword!"
            };

            Go.To<LoginPage>().LogIn(login);

        }
    }
}