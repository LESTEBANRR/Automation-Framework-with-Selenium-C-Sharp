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

            string strFileName = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFileName,FileMode.Open);
            XPathDocument document = new XPathDocument(strFileName);
            XPathNavigator navigator = document.CreateNavigator();
            //GEt XML Details and pass it in XPathItem type variables
            aut = navigator.SelectSingleNode("EAutoFramework/RunSettings/AUT");
            buildName = navigator.SelectSingleNode("EAutoFramework/RunSettings/BuildName");
            testtype = navigator.SelectSingleNode("EAutoFramework/RunSettings/TestType");
            islog = navigator.SelectSingleNode("EAutoFramework/RunSettings/IsLog");
            isreport = navigator.SelectSingleNode("EAutoFramework/RunSettings/IsReport");
            logpath = navigator.SelectSingleNode("EAutoFramework/RunSettings/LogPath");

            Sttings.AUT = aut.ToString();
            Sttings.Build = buildName.ToString();
            Sttings.TestType = testtype.ToString();
            Sttings.IsLog = islog.ToString();
            Sttings.IsReporting = isreport.ToString();
            Sttings.LogPath = logpath.ToString();
        }
    }
}
