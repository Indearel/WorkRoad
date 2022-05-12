using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using WorkRoad;
using NUnit.Framework;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using Allure.Commons;

namespace FromWork
{
    [TestFixture]
    [AllureNUnit]

    public class ByFoot
    {
        private const string MapsUrl = "https://www.google.pl/maps";

        [Test(Description = "Going from work by foot - Google Chrome")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Sergiusz")]
        [AllureIssue("0001")]
        [AllureName("FromWorkByFootGoogleChrome")]
        [AllureTag("From work", "Walk", "Chrome")]
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

                var walkDistance = "#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium";
                //var Distance = "#section-directions-trip-0 div[jsan]:nth-child(2)";
                var distance = driver.FindElement(By.CssSelector(walkDistance)).Text;
                distance = distance.Split()[0];
                //string WalkDistance = walkDistance.GetAttribute("double");
                var WalkDistanceByFoot = Convert.ToDouble(distance);
                Assert.True(WalkDistanceByFoot < 3.0);

                var walkTime = "#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.Fk3sm.fontHeadlineSmall";
                //string WalkTime = walkDistance.GetAttribute("double");
                //var WalkTimeByFoot = Convert.ToDouble(distance);
                var time = driver.FindElement(By.CssSelector(walkTime)).Text;
                time = time.Split()[0];
                var WalkTimeByFoot = Convert.ToDouble(time);
                Assert.True(WalkTimeByFoot < 40.0);

                ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
                Screenshot screenshot = takesScreenshot.GetScreenshot();
                screenshot.SaveAsFile("ByFootFromWorkChrome.jpg", ScreenshotImageFormat.Jpeg);
            }
        }

        [Test(Description = "Going from work by foot - Mozilla Firefox")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Sergiusz")]
        [AllureIssue("0002")]
        [AllureName("FromWorkByFootMozillaFirefox")]
        [AllureTag("From work", "Walk", "Firefox")]
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

                var walkDistance = "#section-directions-trip-0 > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(2)";
                //var Distance = "#section-directions-trip-0 div[jsan]:nth-child(2)";
                var distance = driver.FindElement(By.CssSelector(walkDistance)).Text;
                distance = distance.Split()[0];
                //string WalkDistance = walkDistance.GetAttribute("double");
                var WalkDistanceByFoot = Convert.ToDouble(distance);
                Assert.True(WalkDistanceByFoot < 3);

                var walkTime = "#section-directions-trip-0 > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(1)";
                //string WalkTime = walkDistance.GetAttribute("double");
                //var WalkTimeByFoot = Convert.ToDouble(distance);
                var time = driver.FindElement(By.CssSelector(walkTime)).Text;
                time = time.Split()[0];
                var WalkTimeByFoot = Convert.ToDouble(time);
                Assert.True(WalkTimeByFoot < 40);

                ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
                Screenshot screenshot = takesScreenshot.GetScreenshot();
                screenshot.SaveAsFile("ByFootFromWorkFirefox.jpg", ScreenshotImageFormat.Jpeg);
            }
        }

        [Test(Description = "Going from work by bike - Google Chrome")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Sergiusz")]
        [AllureIssue("0003")]
        [AllureName("FromWorkByBikeGoogleChrome")]
        [AllureTag("From work", "Bike", "Chrome")]
        public void GoogleChrome2()
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
                var RideDistanceByBike = Convert.ToDouble(RideDistance);
                Assert.True(RideDistanceByBike < 3);

                IWebElement rideTime = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.Fk3sm.fontHeadlineSmall"));
                string RideTime = rideTime.GetAttribute("int");
                var RideTimeByBike = Convert.ToDouble(RideTime);
                Assert.True(RideTimeByBike < 40);

                ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
                Screenshot screenshot = takesScreenshot.GetScreenshot();
                screenshot.SaveAsFile("FromWorkByBikeChrome.jpg", ScreenshotImageFormat.Jpeg);
            }
        }

        [Test(Description = "Going from work by bike - Mozilla Firefox")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Sergiusz")]
        [AllureIssue("0004")]
        [AllureName("FromWorkByBikeMozillaFirefox")]
        [AllureTag("From work", "Bike", "Firefox")]
        public void MozillaFirefox2()
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
                var RideDistanceByBike = Convert.ToDouble(RideDistance);
                Assert.True(RideDistanceByBike < 3, "The distance is smaller than the 3 km");

                IWebElement rideTime = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(1)"));
                string RideTime = rideTime.GetAttribute("int");
                var RideTimeByBike = Convert.ToDouble(RideTime);
                Assert.True(RideTimeByBike < 15, "The walk time is smaller than the 40 min");

                ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
                Screenshot screenshot = takesScreenshot.GetScreenshot();
                screenshot.SaveAsFile("FromWorkByBikeFirefox.jpg", ScreenshotImageFormat.Jpeg);
            }
        }
    }

    public class ByBike
    {
        private const string MapsUrl = "https://www.google.pl/maps";

        [Test(Description = "Going from work by bike - Google Chrome")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Sergiusz")]
        [AllureIssue("0003")]
        [AllureName("FromWorkByBikeGoogleChrome")]
        [AllureTag("From work", "Bike", "Chrome")]
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
                var RideDistanceByBike = Convert.ToDouble(RideDistance);
                Assert.True(RideDistanceByBike < 3, "The distance is smaller than the 3 km");

                IWebElement rideTime = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.Fk3sm.fontHeadlineSmall"));
                string RideTime = rideTime.GetAttribute("int");
                var RideTimeByBike = Convert.ToDouble(RideTime);
                Assert.True(RideTimeByBike < 15, "The walk time is smaller than the 40 min");

                ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
                Screenshot screenshot = takesScreenshot.GetScreenshot();
                screenshot.SaveAsFile("FromWorkByBikeChrome.jpg", ScreenshotImageFormat.Jpeg);
            }
        }

        [Test(Description = "Going from work by bike - Mozilla Firefox")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Sergiusz")]
        [AllureIssue("0004")]
        [AllureName("FromWorkByBikeMozillaFirefox")]
        [AllureTag("From work","Bike", "Firefox")]
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
                var RideDistanceByBike = Convert.ToDouble(RideDistance);
                Assert.True(RideDistanceByBike < 3, "The distance is smaller than the 3 km");

                IWebElement rideTime = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(1)"));
                string RideTime = rideTime.GetAttribute("int");
                var RideTimeByBike = Convert.ToDouble(RideTime);
                Assert.True(RideTimeByBike < 15, "The walk time is smaller than the 40 min");

                ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
                Screenshot screenshot = takesScreenshot.GetScreenshot();
                screenshot.SaveAsFile("FromWorkByBikeFirefox.jpg", ScreenshotImageFormat.Jpeg);
            }
        }
    }
}