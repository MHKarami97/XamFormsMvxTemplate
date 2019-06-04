// ---------------------------------------------------------------
// <author>Paul Datsyuk</author>
// <url>https://www.linkedin.com/in/pauldatsyuk/</url>
// ---------------------------------------------------------------

using System.Threading;
using NUnit.Framework;
using Xamarin.UITest;

namespace $safeprojectname$
{
    [TestFixture(Platform.Android, Category = "Andorid")]
    [TestFixture(Platform.iOS, Category = "iOS")]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            //Asserts

            //Press a button
            app.Tap((arg) => arg.Marked("thankYouBtn"));

            Thread.Sleep(2000);
            //Best way - app.WaitForElement(x => x.Marked("imageButton"));

            //Check values
            var results = app.Query("helloLbl");
            Assert.AreEqual("Hello Xamarin!", results[0].Text);
        }
    }
}

