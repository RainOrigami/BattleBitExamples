using BBRAPIModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleBitExamples
{
    [RequireModule(typeof(ExampleModuleIntegration))]
    public class ExampleModule2 : BattleBitModule
    {
        [ModuleReference]
        public ExampleModuleIntegration ExampleModuleIntegration { get; set; }

        // Global configuration
        public static Example2Configuration Configuration { get; set; }

        public override Task OnConnected()
        {
            Console.WriteLine($"{Configuration.Text} from ExampleModule2");
            bool result = this.ExampleModuleIntegration.Test("from ExampleModule2");
            Console.WriteLine($"ExampleModuleIntegration returned {result}");

            Configuration.Text = "Test2";
            Configuration.Save();

            return Task.CompletedTask;
        }
    }
}

public class Example2Configuration : ModuleConfiguration
{
    public string Text { get; set; } = "Test";
}