using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace Appium_WhatsappAutomation
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("deviceName", "Pixel 3a");
            capabilities.SetCapability("udid", "93KAY0C8KD");
            // capabilities.SetCapability("appPackage", "com.google.android.calculator");
            var driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.01:4723/wd/hub"), capabilities);

            driver.FindElement(By.Id("com.whatsapp:id/menuitem_search")).Click();
            driver.FindElement(By.Id("com.whatsapp:id/search_input")).Click();
            driver.FindElement(By.Id("com.whatsapp:id/search_input")).SendKeys("mujahid");
            driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[1]")).Click();

            Thread.Sleep(3000);
            driver.FindElement(By.Id("com.whatsapp:id/input_layout_content")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.Id("com.whatsapp:id/entry")).SendKeys("Hello, Hope you are having a good day");
            driver.FindElement(By.Id("com.whatsapp:id/send")).Click();


        }
    }
}