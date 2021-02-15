using Atata;

namespace DAFT.Framework.Pages.Core
{
    [Url("secure")]
    [VerifyTitle("The Internet")]
    [VerifyH2("Secure Area")]
    public class SecurePageCore<TOwner> : Page<TOwner> where TOwner : SecurePageCore<TOwner>
    {
        public ButtonDelegate<TOwner> Logout { get; private set; }
        [FindById]
        public Text<TOwner> Flash { get; private set; }
        public H4<TOwner> Subheader { get; private set; }
    }
}
