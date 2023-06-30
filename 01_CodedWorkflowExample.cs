using System.Windows.Forms;
using UiPath.CodedWorkflows;

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
            var credentials = system.GetCredential("ACME_Credential");

            // 3. Type Into UserName
            ACMESite.TypeInto("Email", "prasadsatish@outlook.com");

            // 4. Type Into password
            ACMESite.TypeInto("Password", credentials);
            Log("Password from UiPath Orch Assets: " + credentials);

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