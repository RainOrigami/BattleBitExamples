using System;
using System.Threading.Tasks;
using BBRAPIModules;

namespace BattleBitExamples;

public class ExampleModule : BattleBitModule
{
    public ExampleModule(RunnerServer server) : base(server)
    {
    }

    [ModuleReference]
    public BattleBitModule ExampleModuleIntegration { get; set; }

    public override Task OnConnected()
    {
        Console.WriteLine("Hello from ExampleModule");
        if (this.ExampleModuleIntegration is not null)
        {
            bool result = this.ExampleModuleIntegration.Call<bool>("Test", "from ExampleModule");
            Console.WriteLine($"ExampleModuleIntegration returned {result}");
        }

        return Task.CompletedTask;
    }
}