﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using EAEmployeeTest.Pages;
using EAAutoFramework.Base;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using EAAutoFramework.Helpers;
using EAAutoFramework.Config;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1 : Base
    {
                
       

        [TestMethod]
        public void TestMethod1()
        {            
            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";

            ExcellHelpers.PopulateInCollection(fileName);

            LogHelpers.Write("Navigated to the page !!!");

            //LoginPage
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().CheckIfLoginExist();
            CurrentPage.As<LoginPage>().Login(ExcellHelpers.ReadData(1, "UserName"), ExcellHelpers.ReadData(1, "Password"));
            //EmployeePage
            CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();
            CurrentPage.As<EmployeePage>().ClickCreateNew();


        }

        [TestMethod]
        public void TableOperation()
        {
            ConfigReader.SetFrameworkSettings();

            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";

            ExcellHelpers.PopulateInCollection(fileName);

            LogHelpers.CreateLogFile();

            OpenBrowser(BrowserType.FireFox);
            LogHelpers.Write("Opened the browser !!!");

            DriverContext.Browser.GoToUrl(Sttings.AUT);
            LogHelpers.Write("Navigated to the page !!!");

            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().Login(ExcellHelpers.ReadData(1, "UserName"), ExcellHelpers.ReadData(1, "Password"));
            //EmployeePage
            CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();

            var table = CurrentPage.As<EmployeePage>().GetEmployeeList();

            HtmlTableHelper.ReadTable(table);
            HtmlTableHelper.PerformActionOnCell("5", "Name", "Ramesh", "Benefits");



        }


    }
}
