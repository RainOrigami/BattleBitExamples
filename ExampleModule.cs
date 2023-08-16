using System;
using System.Threading.Tasks;
using BBRAPIModules;

namespace BattleBitExamples;

[RequireModule(typeof(ExampleModuleIntegration))]
public class ExampleModule : BattleBitModule
{
    public ExampleModule(RunnerServer server) : base(server)
    {
    }

    private ExampleModuleIntegration exampleModuleIntegration;

    public override void OnModulesLoaded()
    {
        this.exampleModuleIntegration = this.Server.GetModule<ExampleModuleIntegration>()!;
    }

    public override Task OnConnected()
    {
        Console.WriteLine("Hello");
        this.exampleModuleIntegration.Test();
        return Task.CompletedTask;
    }
}