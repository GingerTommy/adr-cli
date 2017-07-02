using System;
using System.Reflection;
using Microsoft.Extensions.CommandLineUtils;

namespace src
{
    internal static class Program
    {
        private const string HelpOption = "-?|-h|--help";

        private static void Main(string[] args)
        {
            var app = new CommandLineApplication();
            app.Name = "adr-cli";
            app.Description = "";

            app.HelpOption(HelpOption);

            app.Command("init", (command) =>
            {
                command.Description = "Init it";
                command.Argument("[directory]", "");
                command.HelpOption(HelpOption);
            });

            app.Command("list", (command) =>
            {
                command.Description = "";
                command.OnExecute(() => {
                    return 0;
                });
            });

            app.Command("new", (command) =>
            {
                command.Description = "";
                command.OnExecute(() =>
                {
                    return 0;
                });
            });

            app.Command("link", (command) =>
            {
                command.Description = "";
                command.OnExecute(() =>
                {
                    return 0;
                });
            });

            app.Command("generate", (command) =>
            {
                command.Description = "";
                command.OnExecute(() =>
                {
                    return 0;
                });
            });

            app.OnExecute(() =>
            {
                app.ShowHelp();
                return 0;
            });
            app.Execute(args);
        }
    }
}
