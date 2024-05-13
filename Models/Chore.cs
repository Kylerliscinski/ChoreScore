namespace ChoreScore.Models;

public class Chore
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string description { get; set; }
  public bool isComplete { get; set; }
}