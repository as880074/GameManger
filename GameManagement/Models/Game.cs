namespace GameManagement.Models;

public class Game
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Merchant { get; set; }
    public string GameType { get; set; }
    public string UserId { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Status { get; set; }
    public string Remarks { get; set; }
}