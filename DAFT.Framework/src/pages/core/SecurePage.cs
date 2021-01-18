using Atata;

namespace DAFT.Framework.pages.core
{
    [Url("secure")]
    [VerifyTitle("The Internet")]
    [VerifyH2("Secure Area")]
    public class SecurePageCore<TOwner> : Page<TOwner> where TOwner : SecurePageCore<TOwner>
    {
        public Button<TOwner> Logout { get; private set; }
    }
}
