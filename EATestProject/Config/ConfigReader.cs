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
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();
            //GEt XML Details and pass it in XPathItem type variables
            aut = navigator.SelectSingleNode("EAAutoFramework/RunSettings/AUT");
            buildName = navigator.SelectSingleNode("EAAutoFramework/RunSettings/BuildName");
            testtype = navigator.SelectSingleNode("EAAutoFramework/RunSettings/TesType");
            islog = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsLog");
            isreport = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsReport");
            logpath = navigator.SelectSingleNode("EAAutoFramework/RunSettings/LogPath");

            Sttings.AUT = aut.ToString();
            Sttings.Build = buildName.ToString();
            Sttings.TestType = testtype.ToString();
            Sttings.IsLog = islog.ToString();
            Sttings.IsReporting = isreport.ToString();
            Sttings.LogPath = logpath.ToString();
        }
    }
}
