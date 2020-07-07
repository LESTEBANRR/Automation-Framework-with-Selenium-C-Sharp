using EAAutoFramework.Base;
using OpenQA.Selenium;
using System;

namespace CrossPlatformEATest.Pages
{
    class CreateEmployeePage : BasePage
    {
        IWebElement txtName => DriverContext.Driver.FindElement(By.Id("Name"));
        IWebElement txtSalary => DriverContext.Driver.FindElement(By.Id("Salary"));
        IWebElement txtDurationWorked => DriverContext.Driver.FindElement(By.Id("DurationWorked"));
        IWebElement txtGrade => DriverContext.Driver.FindElement(By.Id("Grade"));
        IWebElement txtEmail => DriverContext.Driver.FindElement(By.Id("Email"));
        IWebElement btnCreateEmployee => DriverContext.Driver.FindElement(By.XPath("//input[@value='Create']"));

        internal void ClickCreateButton() => btnCreateEmployee.Submit();

        internal void CreateEmployee(string name,string salary, string durationworked, string grade, string email)
        {
            txtName.SendKeys(name);
            txtSalary.SendKeys(salary);
            txtDurationWorked.SendKeys(durationworked);
            txtGrade.SendKeys(grade);
            txtEmail.SendKeys(email);
        }
        
    }
}
