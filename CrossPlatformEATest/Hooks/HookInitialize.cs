using AventStack.ExtentReports.Reporter;
using EAAutoFramework.Base;
using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using TechTalk.SpecFlow;

namespace CrossPlatformEATest
{
	[Binding]
	public class HookInitialize : TestInitializeHook
	{
		/*
         private static ExtentTest featureName;
         private static ExtentTest scenario;
         private static ExtentReports extent;
        //private static Klovreporter klov;
         */


		public HookInitialize() : base(BrowserType.Chrome)
		{
			InitializeSettings();
			Sttings.ApplicationCon = Sttings.ApplicationCon.DBConnect(Sttings.AppConnectionString);
			/*
			var htmlReporter = new ExtentHtmlReporter("URL a guardar el reporte");
			htmlReporter.Configuration.Theme = AventStack.ExtendReports.Reporter.Configuration.Theme.Dark; // Poner el tema oscuro
			extent = new ExtentReports();

			klov = new KlovReporter();
			klov.InitMongoDbConnection("localhost", 27017);
			klov.ProjectName = "ExecuteAutomation Test";
			klov.klovUrl = "http://localhost:5689"; // url of the klov server
			klov.ReportName = "Esteban " + DateTime.Now.ToString();

			extent.AttachReporter(htmlReporter);
			*/
		}
		
		[BeforeFeature]
		public static void TestStart()
		{
			HookInitialize init = new HookInitialize();
		}
		/*
		[AfterTestRun]
		public static void TearDownReport()
		{
			extent.Flush(); // Generar el Reporte
		}
		*/
		[AfterStep]
		public void AfterEachStep()
		{
			var stepName = ScenarioContext.Current.StepContext.StepInfo.Text;
			var featureName = FeatureContext.Current.FeatureInfo.Title;
			var scenarioName = ScenarioContext.Current.ScenarioInfo.Title;

			var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
			/*
			PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("TestStatus", BindingFlags.Instance | BindingFlags.NonPublic);
			MethodInfo getter = pInfo, GetGetMethod(nonPublic: true);
			object TestResult = getter.Invoke(ScenarioContext.Current, null);

			if (ScenarioContext.Current.TestError == null)
			{
				switch (stepType)
				{
					case "Given":
						scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
						break;
					case "When":
						scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
						break;
					case "Then":
						scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
						break;
					case "And":
						scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
						break;
				}
			}
			else
			{
				switch (stepType)
				{
					case "Given":
						scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContextCurrent.TestError.InnerException);
						break;
					case "When":
						scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContextCurrent.TestError.InnerException);
						break;
					case "Then":
						scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContextCurrent.TestError.Message);
						break;
					case "And":
						scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContextCurrent.TestError.InnerException);
						break;
				}
				
				//Pending Status
				if (TestResult.ToString() == "StepDefinitionPending")
				{

					switch (stepType)
					{
						case "Given":
							scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
							break;
						case "When":
							scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
							break;
						case "Then":
							scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
							break;
						case "And":
							scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
							break;

					}
				}
			}*/

		}
		/*
		[BeforeScenario]
		public void Initialize()
        {
			scenario = featureName.CreateNode<Scenario>(ScenarioCOntext.Current.ScenarioInfo.Title);
		}*/
	}
	}