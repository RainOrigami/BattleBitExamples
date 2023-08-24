using System;
using System.Threading.Tasks;
using BBRAPIModules;

namespace BattleBitExamples;

public class ExampleModule : BattleBitModule
{
    [ModuleReference]
    public dynamic? ExampleModuleIntegration { get; set; }

    public override Task OnConnected()
    {
        Console.WriteLine("Hello from ExampleModule");
        if (this.ExampleModuleIntegration is not null)
        {
            bool result = this.ExampleModuleIntegration.Test("from ExampleModule");
            Console.WriteLine($"ExampleModuleIntegration returned {result}");
        }

        return Task.CompletedTask;
    }
}