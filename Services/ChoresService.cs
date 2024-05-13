

namespace ChoreScore.Services;

public class ChoresService
{
  private readonly ChoresRepository _repository;

  public ChoresService(ChoresRepository repository)
  {
    _repository = repository;
  }

  internal List<Chore> GetAllChores()
  {
    List<Chore> chores = _repository.GetAllChores();
    return chores;
  }

  internal Chore CreateChore(Chore choreData)
  {
    Chore chore = _repository.CreateChore(choreData);
    return chore;
  }
}