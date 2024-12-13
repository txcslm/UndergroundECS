using Code.Common;
using Entitas;

namespace Code.Gameplay.Features.Stats.Systems
{
  public class ApplySpeedFromStatsSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _statOwners;

    public ApplySpeedFromStatsSystem(GameContext game)
    {
      _statOwners = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.BaseStats,
          GameMatcher.StatModifiers,
          GameMatcher.InitialWalkSpeed));
    }

    public void Execute()
    {
      foreach (GameEntity statOwner in _statOwners)
      {
        statOwner.ReplaceInitialWalkSpeed(InitialWalkSpeed(statOwner).ZeroIfNegative());
      }
    }

    private float InitialWalkSpeed(GameEntity statOwner)
    {
      return statOwner.BaseStats[StatId.WalkSpeed] + statOwner.StatModifiers[StatId.WalkSpeed];
    }
  }
}