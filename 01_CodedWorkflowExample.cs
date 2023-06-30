using System.Windows.Forms;
using UiPath.CodedWorkflows;
using UiPath.Core.Activities;

namespace CodedAndLowCodeWorkflow
{
    public class _01_CodedWorkflowExample : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
            // 1. Open Application 
            var ACMESite = uiAutomation.Open("LogIn");

            // 2. Get Assets from Orch.
            Log("Reading UserName & Password from UiPath Orch Assets...");
            var credential = system.GetCredential("ACME_Credential", null, out var password, CacheStrategyEnum.None, 30000);

            // 3. Type Into UserName
            ACMESite.TypeInto("Email", credential);

            // 4. Type Into password
            var actualPassword = new System.Net.NetworkCredential(string.Empty, password).Password;
            ACMESite.TypeInto("Password", actualPassword);

            // 5. Click the Submit button to perform the Login
            ACMESite.Click("Login");

            //6. Check if Screen Changed
            var dashboard = uiAutomation.Attach("Dashboard");
            var Description = dashboard.GetText("User options");

            // 6. Display Message 
            Log("Dashboard Appeared..");

        }
    }
}