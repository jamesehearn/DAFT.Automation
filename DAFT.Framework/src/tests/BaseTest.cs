using Atata;
using NUnit.Framework;

namespace DAFT.Framework.Tests
{
    [TestFixture]
    public class BaseTest
    {
        [SetUp]
        protected void SetUp()
        {
            AtataContext.Configure().
                UseChrome().
                WithArguments("start-maximized").
                WithLocalDriverPath().
                UseBaseUrl("https://the-internet.herokuapp.com/").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                AddScreenshotFileSaving().
                LogNUnitError().
                TakeScreenshotOnNUnitError().
                Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
