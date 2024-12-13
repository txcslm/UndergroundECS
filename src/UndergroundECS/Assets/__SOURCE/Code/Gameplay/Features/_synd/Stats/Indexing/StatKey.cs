namespace Code.Gameplay.Features.Stats.Indexing
{
  public struct StatKey
  {
    public readonly int TargetId;
    public readonly StatId Stat;

    public StatKey(int targetId, StatId stat)
    {
      TargetId = targetId;
      Stat = stat;
    }
  }
}