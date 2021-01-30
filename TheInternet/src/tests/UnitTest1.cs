using Atata;
using Bogus.Extensions;
using DAFT.Framework.Data;
using DAFT.Framework.Pages.Core;
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
            var login = new Login();

            Go.To<LoginPage>().LogIn(login);
        }

        [Test]
        public void LoginOption()
        {
            var login = new Login();
            var tCase = new TestCase {Option = "Option 1"};

            Go.To<LoginPage>().LogIn(login);

            Go.To<DropdownPage>().Select(tCase).Options.Should.Equal(tCase.Option);
        }
    }
}