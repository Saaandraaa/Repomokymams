using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTemplate
{
    public class PageObject
    {
        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[1]")]
        public IWebElement departureAirportField;

        [FindsBy(How = How.XPath, Using = "//div[@title='Kaunas International Airport']")]
        public IWebElement kaunasSelection;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[2]")]
        public IWebElement arrivalAirportField;

        [FindsBy(How = How.XPath, Using = "//div[@title='London Gatwick Airport']")]
        public IWebElement gatwickSelection;

        [FindsBy(How = How.XPath, Using = "//label[text()='Airlines *']/..//input")]
        public IWebElement airlinesField;

        [FindsBy(How = How.XPath, Using = "//div[@title='Ryanair']")]
        public IWebElement airlineSelection;

        [FindsBy(How = How.XPath, Using = "//input[@name='failedFlightNumberDigits']")]
        public IWebElement flightNumField;

        [FindsBy(How = How.XPath, Using = "//input[@name='failedFlightDate']")]
        public IWebElement flightDateField;
        
        [FindsBy(How = How.XPath, Using = "//th[@class='rdtPrev']")]
        public IWebElement prevButton;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='22']")]
        public IWebElement dataValue;

        [FindsBy(How = How.XPath, Using = "//span[text()='Flight cancelled']")]
        public IWebElement problemField;

        [FindsBy(How = How.XPath, Using = "//span[text()='Never arrived']")]
        public IWebElement delayedField;

        [FindsBy(How = How.XPath, Using = "//span[text()='Less than 14 days']")]
        public IWebElement informedField;

        [FindsBy(How = How.XPath, Using = "//span[@id='react-select-6--value']")]
        public IWebElement reasonProvidedField;

        [FindsBy(How = How.XPath, Using = "//div[text()='No reason']")]
        public IWebElement dontRemember;
        
        [FindsBy(How = How.XPath, Using = "//span[@id='react-select-7--value']")]
        public IWebElement hearAboutField;

        [FindsBy(How = How.XPath, Using = "//div[text()='Facebook']")]
        public IWebElement hearAbout;

        [FindsBy(How = How.XPath, Using = "//button[text()='Next step']")]
        public IWebElement nextButton;

        [FindsBy(How = How.XPath, Using = "//textarea[@name='comments']")]
        public IWebElement descriptionField;

        [FindsBy(How = How.XPath, Using = "//input[@name='bookingNumber']")]
        public IWebElement reservationNum;
        
        [FindsBy(How = How.XPath, Using = "//button[text()='Enter travellers details']")]
        public IWebElement enterDetailsButton;

        [FindsBy(How = How.XPath, Using = "//input[@name='birthdate']")]
        public IWebElement birthdateField;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='1990']")]
        public IWebElement years;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='11']")]
        public IWebElement month;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='25' and @class='rdtDay']")]
        public IWebElement day;

        [FindsBy(How = How.XPath, Using = "//input[@name='userPhoneCode']")]
        public IWebElement phoneField;

        [FindsBy(How = How.XPath, Using = "//span[@id='react-select-9--value']//input")]
        public IWebElement phone;

        [FindsBy(How = How.XPath, Using = "//div[@title='Lithuania']")]
        public IWebElement lithuaniaField;

        [FindsBy(How = How.XPath, Using = "//span[@id='react-select-10--value']//input[@class='Select-input']")]
        public IWebElement countryField;

        [FindsBy(How = How.XPath, Using = "//div[text()='Lithuania']")]
        public IWebElement selectLithuania;

        [FindsBy(How = How.XPath, Using = "//span[@id='react-select-11--value']//div[text()='Choose language']")]
        public IWebElement languageField;

        [FindsBy(How = How.XPath, Using = "//div[@id='react-select-11--option-5']")]
        public IWebElement selectLt;

        [FindsBy(How = How.XPath, Using = "//span[text()='No, I was travelling alone']")]
        public IWebElement travellingAloneButton;

        [FindsBy(How = How.XPath, Using = "//input[@name='termsCheck']")]
        public IWebElement termsCheckButton;

        [FindsBy(How = How.XPath, Using = "//button[text()='Final step']")]
        public IWebElement finalStep;
    }



}
