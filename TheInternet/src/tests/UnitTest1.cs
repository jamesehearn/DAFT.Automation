using Atata;
using Bogus.Extensions;
using DAFT.Framework.Data;
using NUnit.Framework;
using DAFT.Framework.Tests;
using TheInternet.Pages.Core;
using TheInternet.Data;
using EnumsNET;

namespace TheInternet
{
    public class Tests : BaseTest
    {
        [Test]
        public void Login()
        {
            var login = new LogIn() { Username = "tomsmith", Password = "SuperSecretPassword!"};

            Go.To<LoginPage>().LogIn(login);

            Go.To<SecurePage>().Subheader.Should.Equal("Welcome to the Secure Area. When you are done click logout below.");
        }

        [Test]
        public void LoginOption()
        {
            var login = new LogIn() { Username = "tomsmith", Password = "SuperSecretPassword!" };
            var tCase = new TestCase() {Option = SystemCode.Options.Option1.AsString(EnumFormat.Description)};

            Go.To<LoginPage>().LogIn(login);

            Go.To<DropdownPage>().Select(tCase).Options.Should.Equal(tCase.Option);
        }
    }
}