using Atata;
using DAFT.Framework.Data;

namespace DAFT.Framework.Pages.Core
{
    [Url("dropdown")]
    [VerifyH3("Dropdown List")]
    public class DropdownPageCore<TOwner> : Page<TOwner> where TOwner : DropdownPageCore<TOwner>
    {
        [FindById("dropdown")]
        public Select<TOwner> Options { get; private set; }

        public TOwner Select(TestCase t)
        {
            Options.Set(t.Option);
            return (TOwner)this;
        }
    }
}