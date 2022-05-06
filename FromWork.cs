using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using Xunit;
using System;
using WorkRoad;

namespace FromWork
{
    public class ByFoot
    {
        private const string MapsUrl = "https://www.google.pl/maps";

        [Fact]
        public void GoogleChrome()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(MapsUrl);
                DemoHelper.Pause();

                IWebElement searchInput = driver.FindElement(By.Id("searchboxinput"));
                searchInput.SendKeys("Plac Defilad 1");
                DemoHelper.Pause();

                IWebElement searchButton = driver.FindElement(By.Id("searchbox-searchbutton"));
                searchButton.Click();
                DemoHelper.Pause();

                IWebElement setCourse = driver.FindElement(By.ClassName("EgL07d"));
                setCourse.Click();
                DemoHelper.Pause();

                IWebElement fromWhereSearchInput = driver.FindElement(By.CssSelector("#sb_ifc51 > input"));
                fromWhereSearchInput.SendKeys("Chłodna 51");
                DemoHelper.Pause();

                IWebElement searchForRoad = driver.FindElement(By.CssSelector("#directions-searchbox-0 > button.mL3xi"));
                searchForRoad.Click();
                DemoHelper.Pause();

                IWebElement byFoot = driver.FindElement(By.CssSelector("#omnibox-directions > div > div:nth-child(2) > div > div > div.Qazkze.FkdJRd > div:nth-child(4) > button > img"));
                byFoot.Click();
                DemoHelper.Pause();

                IWebElement walkDistance = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium"));
                string WalkDistance = walkDistance.GetAttribute("int");
                var WalkDistanceByFoot = Convert.ToInt32(WalkDistance);
                Assert.True(WalkDistanceByFoot < 3, "The distance is smaller than the 3 km");

                IWebElement walkTime = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.Fk3sm.fontHeadlineSmall"));
                string WalkTime = walkDistance.GetAttribute("int");
                var WalkTimeByFoot = Convert.ToInt32(WalkTime);
                Assert.True(WalkDistanceByFoot < 40, "The walk time is smaller than the 40 min");
            }
        }

        [Fact]
        public void MozillaFirefox()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl(MapsUrl);
                DemoHelper.Pause();

                IWebElement searchInput = driver.FindElement(By.Id("searchboxinput"));
                searchInput.SendKeys("Plac Defilad 1");
                DemoHelper.Pause();

                IWebElement searchButton = driver.FindElement(By.Id("searchbox-searchbutton"));
                searchButton.Click();
                DemoHelper.Pause();

                IWebElement setCourse = driver.FindElement(By.CssSelector("div.etWJQ:nth-child(1) > button:nth-child(1) > span:nth-child(1) > img:nth-child(1)"));
                setCourse.Click();
                DemoHelper.Pause();

                IWebElement fromWhereSearchInput = driver.FindElement(By.CssSelector("#sb_ifc51 > input:nth-child(1)"));
                fromWhereSearchInput.SendKeys("Chłodna 51");
                DemoHelper.Pause();

                IWebElement searchForRoad = driver.FindElement(By.CssSelector("#directions-searchbox-0 > button:nth-child(2)"));
                searchForRoad.Click();
                DemoHelper.Pause();

                IWebElement byFoot = driver.FindElement(By.CssSelector("div.oya4hc:nth-child(4) > button:nth-child(1) > img:nth-child(1)"));
                byFoot.Click();
                DemoHelper.Pause();

                IWebElement walkDistance = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(2)"));
                string WalkDistance = walkDistance.GetAttribute("int");
                var WalkDistanceByFoot = Convert.ToInt32(WalkDistance);
                Assert.True(WalkDistanceByFoot < 3, "The distance is smaller than the 3 km");

                IWebElement walkTime = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(1)"));
                string WalkTime = walkDistance.GetAttribute("int");
                var WalkTimeByFoot = Convert.ToInt32(WalkTime);
                Assert.True(WalkDistanceByFoot < 15, "The walk time is smaller than the 40 min");
            }
        }
    }

    public class ByBike
    {
        private const string MapsUrl = "https://www.google.pl/maps";

        [Fact]
        public void GoogleChrome()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(MapsUrl);
                DemoHelper.Pause();

                IWebElement searchInput = driver.FindElement(By.Id("searchboxinput"));
                searchInput.SendKeys("Plac Defilad 1");
                DemoHelper.Pause();

                IWebElement searchButton = driver.FindElement(By.Id("searchbox-searchbutton"));
                searchButton.Click();
                DemoHelper.Pause();

                IWebElement setCourse = driver.FindElement(By.ClassName("EgL07d"));
                setCourse.Click();
                DemoHelper.Pause();

                IWebElement fromWhereSearchInput = driver.FindElement(By.CssSelector("#sb_ifc51 > input"));
                fromWhereSearchInput.SendKeys("Chłodna 51");
                DemoHelper.Pause();

                IWebElement searchForRoad = driver.FindElement(By.CssSelector("#directions-searchbox-0 > button.mL3xi"));
                searchForRoad.Click();
                DemoHelper.Pause();

                IWebElement byBike = driver.FindElement(By.CssSelector("#omnibox-directions > div > div:nth-child(2) > div > div > div.IqV6ub > div.FkdJRd > div.oya4hc.vxq1Hc > button > img"));
                byBike.Click();
                DemoHelper.Pause();

                IWebElement rideDistance = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium"));
                string RideDistance = rideDistance.GetAttribute("int");
                var RideDistanceByBike = Convert.ToInt32(RideDistance);
                Assert.True(RideDistanceByBike < 3, "The distance is smaller than the 3 km");

                IWebElement rideTime = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.Fk3sm.fontHeadlineSmall"));
                string RideTime = rideTime.GetAttribute("int");
                var RideTimeByBike = Convert.ToInt32(RideTime);
                Assert.True(RideTimeByBike < 15, "The walk time is smaller than the 40 min");
            }
        }
        [Fact]
        public void MozillaFirefox()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl(MapsUrl);
                DemoHelper.Pause();

                IWebElement searchInput = driver.FindElement(By.Id("searchboxinput"));
                searchInput.SendKeys("Plac Defilad 1");
                DemoHelper.Pause();

                IWebElement searchButton = driver.FindElement(By.Id("searchbox-searchbutton"));
                searchButton.Click();
                DemoHelper.Pause();

                IWebElement setCourse = driver.FindElement(By.CssSelector("div.etWJQ:nth-child(1) > button:nth-child(1) > span:nth-child(1) > img:nth-child(1)"));
                setCourse.Click();
                DemoHelper.Pause();

                IWebElement fromWhereSearchInput = driver.FindElement(By.CssSelector("#sb_ifc51 > input:nth-child(1)"));
                fromWhereSearchInput.SendKeys("Chłodna 51");
                DemoHelper.Pause();

                IWebElement searchForRoad = driver.FindElement(By.CssSelector("#directions-searchbox-0 > button:nth-child(2)"));
                searchForRoad.Click();
                DemoHelper.Pause();

                IWebElement byBike = driver.FindElement(By.CssSelector(".IqV6ub > div:nth-child(1) > div:nth-child(1) > button:nth-child(1) > img:nth-child(1)"));
                byBike.Click();
                DemoHelper.Pause();

                IWebElement rideDistance = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium"));
                string RideDistance = rideDistance.GetAttribute("int");
                var RideDistanceByBike = Convert.ToInt32(RideDistance);
                Assert.True(RideDistanceByBike < 3, "The distance is smaller than the 3 km");

                IWebElement rideTime = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(1)"));
                string RideTime = rideTime.GetAttribute("int");
                var RideTimeByBike = Convert.ToInt32(RideTime);
                Assert.True(RideTimeByBike < 15, "The walk time is smaller than the 40 min");
            }
        }
    }
}