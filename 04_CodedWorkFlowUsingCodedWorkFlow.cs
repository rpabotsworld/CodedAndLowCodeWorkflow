using System.Collections.Generic;
using UiPath.CodedWorkflows;


namespace CodedAndLowCodeWorkflow
{
    public class _04_CodedWorkFlowUsingCodedWorkFlow : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
            // Requirements:
            // - Create an asset of type Text called MyAsset in the current folder.

            var result = RunWorkflow("03_CodedWorkflowWithArguments.cs", new Dictionary<string, object>(){
                        {"assetName", "MyAsset"},
                        {"assetValue", "hello world"}
                    });

            if ((bool)result["assetValueWasChanged"])
            {
                Log("Reset asset MyAsset, but it had a different value, previous value was " + result["assetValue"]);
            }
            else
            {
                Log("No reset was required on asset MyAsset, which had the expected value.");
            }
        }
    }
}