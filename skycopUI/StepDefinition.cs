using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;


namespace SeleniumTemplate
{
    [Binding]
    public class StepDefinition
    {
        private PageObject _pageObject;
        public PageObject PageObject => _pageObject ?? (_pageObject = new PageObject());
        public static IWebDriver Driver;
        public class Browser 

        {
            public IWebDriver Chrome;

            public Browser()
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                Chrome = new ChromeDriver(options);
            }
        }
        public void FillTextField(string xPath, string text)
        {
            Thread.Sleep(500);
            var field = Driver.FindElement(By.XPath(xPath));
            field.SendKeys(text);
        }


        public StepDefinition(Browser browser)
        {
            Driver = browser.Chrome;
            PageFactory.InitElements(Driver, PageObject);
        }

        [Given(@"I navigate to claims")]
        public void GivenIOpenSkycopClaimPage()
        {
            Driver.Url = "https://claim.skycop.com/";
        }

        [Then(@"I set Kaunas as departure airport")]
        public void ThenISetKaunasAsDepartureAirport()
        {
            Thread.Sleep(2000);
            PageObject.departureAirportField.SendKeys(Constants.city);
            Thread.Sleep(2000);
            PageObject.kaunasSelection.Click();

        }
        [Then(@"I set London Gatwick as arrival airport")]
        public void ThenISetLondonGatwickAsArrivalAirport()
        {
            PageObject.arrivalAirportField.SendKeys(Constants.city2);
            Thread.Sleep(2000);
            PageObject.gatwickSelection.Click();

        }
        [Then(@"I choose airlines")]
        public void ThenIChooseAirlines()
        {
            Thread.Sleep(2000);
            PageObject.airlinesField.SendKeys(Constants.airlines);
            Thread.Sleep(4000);
            PageObject.airlineSelection.Click();
        }
        [Then(@"I set flight number")]
        public void ThenISetFlightNumber()
        {
            int num = new Random().Next(1000, 9999);

            PageObject.flightNumField.SendKeys(Convert.ToString(num));
            
        }
        [Then(@"I set flight date")]
        public void ThenISetFlightDate()
        {

            PageObject.flightDateField.Click();
            Thread.Sleep(500);
            PageObject.prevButton.Click();
            PageObject.dataValue.Click();
        }
        [Then(@"I choose the problem of the flight encountered")]
        public void ThenIChooseTheProblemOfTheFlightEncountered()
        {
            Thread.Sleep(500);
           PageObject.problemField.Click();
        }

        [Then(@"I choose how long delayed")]
        public void ThenIChooseHowLongDelayed()
        {
            Thread.Sleep(2000);
            PageObject.delayedField.Click();
        }

        [Then(@"I choose when informed")]
        public void ThenIChooseWhenInformed()
        {
            Thread.Sleep(2000);
            PageObject.informedField.Click();
        
        }
        [Then(@"I choose reason provided")]
        public void ThenIChooseReasonProvided()
        {
            Thread.Sleep(2000);
            PageObject.reasonProvidedField.Click();
            Thread.Sleep(2000);
            PageObject.dontRemember.Click();
        }
        
        [Then(@"I choose where hear about")]
        public void ThenIChooseWhereHearAbout()
        {
            Thread.Sleep(2000);
            PageObject.hearAboutField.Click();
            Thread.Sleep(2000);
            PageObject.hearAbout.Click();
        }
        [Then(@"I click next step button")]
        public void ThenIClickNextStepButton()
        {
            PageObject.nextButton.Click();
        }
        [Then(@"I describe situation")]
        public void ThenIDescribeSituation()
        {
            Thread.Sleep(2000);
           PageObject.descriptionField.SendKeys(Constants.problemDescription);
        }
        [Then(@"I set flight reservation number")]
        public void ThenISetFlightReservationNumber()
        {
           PageObject.reservationNum.SendKeys(Constants.reservationNumber);
        }
        [Then(@"I click enter travellers details")]
        public void ThenIClickEnterTravellersDetails()
        {
            PageObject.enterDetailsButton.Click();
        }
        [Then(@"I fill name field")]
        public void ThenIFillNameField()
        {
            FillTextField("//input[@name='userName']", "Sandra");
        }
        [Then(@"I fill surname field")]
        public void ThenIFillSurnameField()
        {
            FillTextField("//input[@name='userSurname']", "Kibarte");
        }
        [Then(@"I fill birthdate field")]
        public void ThenIFillBirthdateField()
        {
            PageObject.birthdateField.Click();
            PageObject.years.Click();
            Thread.Sleep(2000);
            PageObject.month.Click();
            PageObject.day.Click();
        }
        [Then(@"I fill email field")]
        public void ThenIFillEmailField()
        {
            FillTextField("//input[@name='userEmail']", "sandraralyt@gmail.com");
        }

        [Then(@"I fill repeat email field")]
        public void ThenIFillRepeatEmailField()
        {
            FillTextField("//input[@name='repeatEmail']", "sandraralyt@gmail.com");
        }
        [Then(@"I set user phone")]
        public void ThenISetUserPhone()
        {
            Thread.Sleep(2000);
            PageObject.phoneField.Click();
            PageObject.phone.SendKeys(Constants.phoneCode);
            PageObject.lithuaniaField.Click();
            FillTextField("//input[@name='userPhone']", "64621287");
        }
        [Then(@"I fill address")]
        public void ThenIFillAddress()
        {
            FillTextField("//input[@name='userAddress']", "Laisvės 54");
        }
        [Then(@"I fill city")]
        public void ThenIFillCity()
        {
            FillTextField("//input[@name='userCity']", "Kaunas");
        }
        [Then(@"I fill post code")]
        public void ThenIFillPostCode()
        {
            FillTextField("//input[@name='userPostCode']", "44470");
        }
        [Then(@"I set country")]
        public void ThenISetCountry()
        {
            Thread.Sleep(100);
            PageObject.countryField.SendKeys(Constants.country);
            Thread.Sleep(500);
            PageObject.selectLithuania.Click();
        }
        [Then(@"I set language")]
        public void ThenISetLanguage()
        {
            Thread.Sleep(500);
            PageObject.languageField.Click();
            PageObject.selectLt.Click();
        }
        [Then(@"I choose travelling alone")]
        public void ThenIChooseTravellingAlone()
        {
            Thread.Sleep(500);
            PageObject.travellingAloneButton.Click();
        }
        [Then(@"I click on terms check")]
        public void ThenIClickOnTermsCheck()
        {
            PageObject.termsCheckButton.Click();
        }
        [Then(@"I click final step butoon")]
        public void ThenIClickFinalStepButoon()
        {
            PageObject.finalStep.Click();
        }
        //[Then(@"I sign")]
        //public void ThenISign()
        //{
        // Thread.Sleep(500);
        //    var signField = Driver.FindElement(By.XPath("//canvas[@id='sigCanvas']"));
        //    Actions builder = new Actions(Driver);
        //    IAction drawAction = builder.MoveToElement(signField, 10, 10)
        //    .ClickAndHold()
        //    .MoveByOffset(50, 50)
        //    .Release();
        //    .Build();
        ///   drawAction.Perform();
            //Actions builder = new Actions(Driver);
            //Actions drawAction = builder.MoveToElement(signField, 10, 10);
            //drawAction.Click();
        }

    }

