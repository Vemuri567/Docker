using Microsoft.Win32.SafeHandles;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CICD_Testing
{
    public class Tests
    {
        private static IWebDriver uniqueInstanceWebDriver = null;
        [SetUp]
        public void Setup()
        {
            string appdatapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            appdatapath = appdatapath.Replace("Roaming", "");
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--no-sandbox");
            options.AddArguments("--disabled-dev-shm-usage");
            options.AddArguments("--headless");
            options.AcceptInsecureCertificates = true;
            options.AddArgument("--ignore-ssl-errors=yes");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument(string.Format("user-data-dir={0}", appdatapath + "Google\\Chrome\\User Data"));
            options.AddUserProfilePreference("download.prompt_for_download", true);
            options.AddArguments("--disable-extensions");
           
            uniqueInstanceWebDriver = new ChromeDriver(options);
        }

        [Test]
        public void Test1()
        {
            uniqueInstanceWebDriver.Url = "https://youtube.com/";
            Console.WriteLine("output");
        }

        [Test]
        public void Test2()
        {
            uniqueInstanceWebDriver.Url = "https://youtube.com/";
        }

        [Test]
        public void Test3()
        {
            uniqueInstanceWebDriver.Url = "https://youtube.com/";
        }

        [Test]
        public void Test4()
        {
            uniqueInstanceWebDriver.Url = "https://youtube.com/";
        }

        [Test]
        public void Test5()
        {
            uniqueInstanceWebDriver.Url = "https://youtube.com/";
        }


        [TearDown]
        public void TearDown()
        {
            uniqueInstanceWebDriver.Quit();
        }
    }
}