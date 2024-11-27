using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V129.Storage;
using System;

class CloudQAAutomation
{
    static void Main(string[] args)
    {
        
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        try
        {
            
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            // testing firstname field
            var firstNameField = driver.FindElement(By.Id("fname")); 
            firstNameField.Clear();
            firstNameField.SendKeys("Test User");
            Console.WriteLine("First Name field test passed.");

            // testing Email field
            var emailField = driver.FindElement(By.Id("email")); 
            emailField.Clear();
            emailField.SendKeys("testuser@example.com");
            Console.WriteLine("Email field test passed.");

           // testing Gender Radio input
            var genderRadio = driver.FindElement(By.CssSelector("input[name='gender'][value='Male']")); 
            genderRadio.Click();
            Console.WriteLine("Gender selection test passed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Test failed: {ex.Message}");
        }
        finally
        {
            driver.Quit();
        }
    }
}
