using Code.Common;
using Code.Infrastructure.Loading;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Scenes.Hubs
{
  public class GameplayInitializer : MonoBehaviour
  {
    private SceneLoader _sceneLoader;

    [Inject]
    public void Construct(SceneLoader sceneLoader, GameplayInstaller gameplayInstaller)
    {
      _sceneLoader = sceneLoader;
    }

    private void Start()
    {
      Time.timeScale = 1f;

      CreateEntity
        .Empty();
    }

    public void Restart()
    {
      Destroy();

      _sceneLoader.Load(SceneId.LoadProgress);
    }

    private void Destroy()
    {
      Time.timeScale = 0f;
    }
  }
}