//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPlayerCamera;

    public static Entitas.IMatcher<GameEntity> PlayerCamera {
        get {
            if (_matcherPlayerCamera == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerCamera);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerCamera = matcher;
            }

            return _matcherPlayerCamera;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Code.Gameplay.Features.PlayerCameras.PlayerCamera playerCameraComponent = new Code.Gameplay.Features.PlayerCameras.PlayerCamera();

    public bool isPlayerCamera {
        get { return HasComponent(GameComponentsLookup.PlayerCamera); }
        set {
            if (value != isPlayerCamera) {
                var index = GameComponentsLookup.PlayerCamera;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : playerCameraComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
