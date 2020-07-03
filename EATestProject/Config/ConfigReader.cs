using System;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace EAAutoFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            XPathItem aut;
            XPathItem testtype;
            XPathItem buildName;
            XPathItem islog;
            XPathItem isreport;
            XPathItem logpath;
            XPathItem appConnection;

            //string strFileName = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            string strFileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFileName,FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();
            //GEt XML Details and pass it in XPathItem type variables
            aut = navigator.SelectSingleNode("EAAutoFramework/RunSettings/AUT");
            buildName = navigator.SelectSingleNode("EAAutoFramework/RunSettings/BuildName");
            testtype = navigator.SelectSingleNode("EAAutoFramework/RunSettings/TesType");
            islog = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsLog");
            isreport = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsReport");
            logpath = navigator.SelectSingleNode("EAAutoFramework/RunSettings/LogPath");
            appConnection = navigator.SelectSingleNode("EAAutoFramework/RunSettings/ApplicationDb");
            //Set XML Details
            Sttings.AUT = aut.Value.ToString();
            Sttings.Build = buildName.Value.ToString();
            Sttings.TestType = testtype.Value.ToString();
            Sttings.IsLog = islog.Value.ToString();
            Sttings.IsReporting = isreport.Value.ToString();
            Sttings.LogPath = logpath.Value.ToString();
            Sttings.AppConnectionString = appConnection.Value.ToString();
        }
    }
}
