using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;

namespace WorkRoad
{
    internal class DurationChrome
    {
        private const string MapsUrl = "https://www.google.pl/maps";
        public static void Duration()
        { 
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(MapsUrl);
                DemoHelper.Pause();

                var durationSelector = "#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.Fk3sm.fontHeadlineSmall";
                var walkDurationSelector = driver.FindElement(By.CssSelector(durationSelector)).Text;
                var Duration = walkDurationSelector.Split()[0];
                var WalkDuration = Convert.ToDouble(Duration);
                Assert.True(WalkDuration < 40);
                if (WalkDuration < 40)
                {
                    Console.WriteLine("It takes less than 40 minutes to cross the road ");
                }
                else
                {
                    Console.WriteLine("It takes more than 40 minutes to cross the road");
                }
            }   
        }
    }
}