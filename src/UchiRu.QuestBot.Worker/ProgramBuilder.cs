using UchiRu.QuestBot.Worker.Services;

namespace UchiRu.QuestBot.Worker; 

public class ProgramBuilder {

    public ProgramBuilder() {
        
        var builder = Host.CreateApplicationBuilder();
        builder.Services.AddSingleton<ApplicationContext>();
        builder.Services.AddSingleton<QuestReader>();
        builder.Services.AddHostedService<Worker>();
        builder.Build().Run();
    }
    
}