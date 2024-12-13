using Code.Common.Destruct;
using Code.Gameplay.Common.Timers;
using Code.Gameplay.Features;
using Code.Gameplay.Features.Inputs;
using Code.Gameplay.Features.Lifetime.Systems;
using Code.Gameplay.Features.Movement;
using Code.Gameplay.Features.Player;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View;

namespace Code.Gameplay
{
  public sealed class GameplayFeature : Feature
  {
    public GameplayFeature(ISystemFactory systems)
    {
      Add(systems.Create<InputFeature>());
      Add(systems.Create<BindViewFeature>());
      Add(systems.Create<TimerFeature>());

      Add(systems.Create<RaycastFeature>());
      Add(systems.Create<PlayerFeature>());
      Add(systems.Create<MovementFeature>());
      Add(systems.Create<RotationFeature>());
      Add(systems.Create<DeathFeature>());

      Add(systems.Create<ProcessDestructedFeature>());
      Add(systems.Create<CameraFeature>());
    }
  }
}