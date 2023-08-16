using BBRAPIModules;

namespace BattleBitExamples;

public class ExampleModuleIntegration : BattleBitModule
{
    public ExampleModuleIntegration(RunnerServer server) : base(server)
    {
    }

    public void Test()
    {
        this.Server.SayToChat("Test");
    }
}
