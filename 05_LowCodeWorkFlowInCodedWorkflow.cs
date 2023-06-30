using System.Collections.Generic;
using UiPath.CodedWorkflows;

namespace CodedAndLowCodeWorkflow
{
    public class _05_LowCodeWorkFlowInCodedWorkflow : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
         
            Log("Lets Invoke LowCode Workflow here..!");
            var result = RunWorkflow("Login.xaml", new Dictionary<string, object>()
              {
                {"in_AssetName", "ACME_Credential"},
              });
        }
    }
}