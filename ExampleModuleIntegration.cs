using System;
using System.Threading;
using BBRAPIModules;

namespace BattleBitExamples;

public class ExampleModuleIntegration : BattleBitModule
{
    // Per-server configuration
    public ExampleConfiguration ExampleModuleConfig { get; set; }

    public ExampleModuleIntegration(RunnerServer server) : base(server)
    {
    }

    public bool Test(string text)
    {
        Console.WriteLine($"{this.ExampleModuleConfig.Text} {text}");

        return Random.Shared.Next(0, 2) == 1;
    }
}

public class ExampleConfiguration : ModuleConfiguration
{
    public string Text { get; set; } = "Test";
}