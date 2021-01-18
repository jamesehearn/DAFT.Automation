using Atata;
using DAFT.Framework.Data;

namespace DAFT.Framework.Pages.Core
{
    [Url("login")]
    [VerifyH2("Login Page")]
    public class LoginPageCore<TOwner> : Page<TOwner> where TOwner : LoginPageCore<TOwner>
    {
        public TextInput<TOwner> Username { get; private set; }

        public PasswordInput<TOwner> Password { get; private set; }

        public Button<TOwner> Login { get; private set; }

        public TOwner LogIn(Login l)
        {
            Username.Set(l.Username).Password.Set(l.Password).Login.Click();
            return (TOwner)this;
        }
    }
}
