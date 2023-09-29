using System.ComponentModel.DataAnnotations;

namespace UchiRu.QuestBot.Worker.DbTables; 


public class User {
    [Key] public int Id { get; set; }
    public int QuestionId { get; set; }
    public string UserTelegramId { get; set; } = string.Empty;
}