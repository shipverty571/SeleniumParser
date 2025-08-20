using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Core;

public class DriverFactory
{
    public IWebDriver Create()
    {
        var service = ChromeDriverService.CreateDefaultService();
        var options = new ChromeOptions();
        options.AddArguments("--disable-gpu", "--no-sandbox", "--window-size=1920,1080");

        return new ChromeDriver(service, options);
    }
}