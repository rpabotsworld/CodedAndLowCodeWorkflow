using UiPath.CodedWorkflows;

namespace CodedAndLowCodeWorkflow
{
    public class _00_FirstCodedWorkflow : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
            Log("Hello World from Coded Workflows!");
        }
    }
}