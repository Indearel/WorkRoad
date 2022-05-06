using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using Xunit;
using System;

namespace WorkRoad
{
    public class ToWork
    {
        //int runCount = int.Parse(driver.FindElement(By.Id("current_index")).Text);
        //int walkDistance = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium"));
        //// driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium"));
        //// var baseWalkDistance = walkDistance.GetAttribute("3 km");
        //// if (walkDistance > baseWalkDistance)

        private const string MapsUrl = "https://www.google.pl/maps";

        [Fact]
        public void Chrome()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(MapsUrl);
                DemoHelper.Pause();

                IWebElement searchInput = driver.FindElement(By.Id("searchboxinput"));
                searchInput.SendKeys("Chłodna 51");
                DemoHelper.Pause();

                IWebElement searchButton = driver.FindElement(By.Id("searchbox-searchbutton"));
                searchButton.Click();
                DemoHelper.Pause();

                IWebElement setCourse = driver.FindElement(By.ClassName("EgL07d"));
                setCourse.Click();
                DemoHelper.Pause();

                IWebElement fromWhereSearchInput = driver.FindElement(By.CssSelector("#sb_ifc51 > input"));
                fromWhereSearchInput.SendKeys("Plac Defilad 1");
                DemoHelper.Pause();

                IWebElement searchForRoad = driver.FindElement(By.CssSelector("#directions-searchbox-0 > button.mL3xi"));
                searchForRoad.Click();
                DemoHelper.Pause();

                IWebElement byFoot = driver.FindElement(By.CssSelector("#omnibox-directions > div > div:nth-child(2) > div > div > div.Qazkze.FkdJRd > div:nth-child(4) > button > img"));
                byFoot.Click();
                DemoHelper.Pause();

                IWebElement walkDistance = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium"));
                var walkDistanceByFoot = walkDistance.Int32;
                string input = Console.ReadLine();

                walkDistanceByFoot = Convert.ToInt32(input);

                // int walkDistanceByFoot = int.Parse(driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium")).Text);
                Console.WriteLine(walkDistanceByFoot);
                //if (walkDistanceByFoot < 3)
                //{
                //    Console.WriteLine();
                //}

                //IWebElement walkTime = driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.Fk3sm.fontHeadlineSmall"));
            }
        }

        [Fact]
        public void getDistance() { 
            using (IWebDriver driver = new ChromeDriver()){
            {
                int walkDistanceByFoot = int.Parse(driver.FindElement(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium")).Text);
                if (walkDistanceByFoot < 3)
                   {
                        Console.WriteLine();
                    }
            }
        }

        //private int GetInt()
        //{

        //    return
        //}
    }

    public class FromWork
    {

    }
}
