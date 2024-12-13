using Code.Gameplay.Features.Models;
using Code.Gameplay.Features.Movement.Systems;
using Code.Infrastructure.Systems;
using Zenject;

namespace Code.Infrastructure.Scenes.Hubs
{
  public class GameplayInstaller : MonoInstaller
  {

    public override void InstallBindings()
    {
      Container.Bind<GameplayInitializer>().FromInstance(GetComponent<GameplayInitializer>()).AsSingle().NonLazy();
      Container.Bind<GameplayInstaller>().FromInstance(this).AsSingle();

      Container.Bind<ISystemFactory>().To<SystemFactory>().AsSingle();

      Container.BindInterfacesAndSelfTo<MoveCharacterControllerSystem>().AsSingle();

      GameplayHeadsUpDisplay();
    }

    private void GameplayHeadsUpDisplay()
    {
      Container.BindInterfacesAndSelfTo<CurrentRaycastDistanceModel>().AsSingle();
      Container.BindInterfacesAndSelfTo<SingleRaycasterTargetIdModel>().AsSingle();
    }
  }
}