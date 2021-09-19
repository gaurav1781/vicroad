//using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

namespace vicroad.feature
{
    [Binding]
    public class TestSteps
    {
        IWebDriver dr;
         [Given(@"User visits vicroads website")]
        
        public void login()
         {
          
          dr = new ChromeDriver("D:\\Selenium\\Drivers");
         dr.Url = objectrepos.URL;
          dr.Manage().Window.FullScreen();

         }

        [Given(@"User selects passenger vehicle")]
        public void vehicle_drpdwon()
        {

            /* Step to select the vehicle type  */

            var veh_typ_drpdwn = new SelectElement(dr.FindElement(By.XPath(objectrepos.vehicle_drpdwn)));
            /* Select passenger vehicle  */
            veh_typ_drpdwn.SelectByIndex(1);
        }
        [Given(@"fills information")]
        public void GivenFillsInformation()
        {
            /* Select Passenger vehicle type  */
            var psng_veh_type = new SelectElement(dr.FindElement(By.XPath(objectrepos.psng_type)));
            psng_veh_type.SelectByIndex(1);

            /* Fill the Address */
            dr.FindElement(By.XPath(objectrepos.address)).SendKeys("Unit 13 King Street Dandenong 3175");
            /* Fill the Permit Date */
            dr.FindElement(By.XPath(objectrepos.date)).Clear();
            // TimeUnit.SECONDS.sleep(5);
            dr.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(5);
            dr.FindElement(By.XPath(objectrepos.date)).SendKeys("19/09/2021");

            /* Fill the Permit Duration */
            var permit_duration = new SelectElement(dr.FindElement(By.XPath(objectrepos.permit_duration)));
            permit_duration.SelectByIndex(2);
        }
        [When(@"User clicks calculator - Submit Order")]
        public void submit_order()
        {
            /* Click the calculator to calculate the amount */
            dr.FindElement(By.XPath(objectrepos.click_calc)).Click();
            /* Submit the request */
            dr.FindElement(By.XPath(objectrepos.submit)).Click();
        }
        [Then(@"Pass amount is calculated and User is taken to next pages")]
        public void user_next_page1()
        {
            //System.out.println("Execution complete");
            dr.Quit();
        }
        [Given(@"newUser selects Goods carrying vehicle")]
        public void select_goods_veh()
        {
            /* Step to select the vehicle type  */

            var veh_typ_drpdwn = new SelectElement(dr.FindElement(By.XPath(objectrepos.vehicle_drpdwn)));
            /* Select passenger vehicle  */
            veh_typ_drpdwn.SelectByIndex(2);
        }

        [Given(@"newUser selects carrying vehicle type")]
        public void veh_type()
        {
            /* Select Goods-carrying vehicle type  */
            var psng_veh_type = new SelectElement(dr.FindElement(By.XPath(objectrepos.goods_carrier_type)));
            psng_veh_type.SelectByIndex(2);
        }

        [Given(@"newUser fills Address")]
        public void User_FillsAddress()
        {
            /* Fill the Address */
            dr.FindElement(By.XPath(objectrepos.address)).SendKeys("Unit 13 King Street Dandenong 3175");
        }

        [Given(@"newUser fills the Permit Date")]
        public void UserFills_PermitDate()
        {
            /* Fill the Permit Date */
            dr.FindElement(By.XPath(objectrepos.date)).Clear();

            dr.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(5);
            dr.FindElement(By.XPath(objectrepos.date)).SendKeys("19/09/2021");
        }

        [Given(@"newUser fills the Permit Duration")]
        public void GivenUserFillsThePermitDuration()
        {
            /* Fill the Permit Duration */
            var permit_duration = new SelectElement(dr.FindElement(By.XPath(objectrepos.permit_duration)));
            permit_duration.SelectByIndex(2);
        }

        [Given(@"newUser clicks calculator - Submit Order")]
        public void User_ClicksCalculator()
        {
            /* Click the calculator to calculate the amount */
            dr.FindElement(By.XPath(objectrepos.click_calc)).Click();
            /* Submit the request */
            dr.FindElement(By.XPath(objectrepos.submit)).Click();
        }

        [Then(@"Pass amount is calculated and newUser is taken to next pages")]
        public void user_next_page()
        {
            //dr.Quit();
        }
    }

        
}

