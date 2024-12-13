using Code.Gameplay.Features.Stats.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Stats
{
  public sealed class StatsFeature : Feature
  {
    public StatsFeature(ISystemFactory systems)
    {
      Add(systems.Create<StatChangeSystem>());
      
      Add(systems.Create<ApplySpeedFromStatsSystem>());
    }
  }
}