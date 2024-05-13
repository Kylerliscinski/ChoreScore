


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

  internal Chore GetChoreById(int choreId)
  {
    Chore chore = _repository.GetChoreById(choreId);

    if (chore == null)
    {
      throw new Exception($"Invalid id: {choreId}");
    }

    return chore;
  }

  internal string DestroyChore(int choreId)
  {
    Chore choreToDestroy = GetChoreById(choreId);

    _repository.DestroyChore(choreId);

    return $"{choreToDestroy.Name} is removed";
  }
}