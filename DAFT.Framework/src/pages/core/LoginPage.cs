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

        public ButtonDelegate<TOwner> Login { get; private set; }

        public TOwner LogIn(LoginBase l)
        {
            //Username.Set(l.Username).Password.Set(l.Password).Login.ClickAndGo<>();
            //return (TOwner)this;
            return Username.Set(l.Username).Password.Set(l.Password).Login();
        }
    }
}
