using System.CommandLine;
using UchiRu.QuestBot.Worker;


var fileOption = new Option<FileInfo?>(
    aliases: new []{"-f", "--file"},
    description: "The file to read and display on the console.");

var runCommand = new Command(
    name: "run",
    description: "Run application.");
runCommand.AddAlias("-r");

runCommand.SetHandler(() => {
     new ProgramBuilder();
});

var rootCommand = new RootCommand("Sample app for System.CommandLine");
rootCommand.AddOption(fileOption);

rootCommand.SetHandler((file) => 
    {
        if (file != null) {
            
        }
    },
    fileOption);
rootCommand.AddCommand(runCommand);

await rootCommand.InvokeAsync(args);