//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherRotationReady;

    public static Entitas.IMatcher<GameEntity> RotationReady {
        get {
            if (_matcherRotationReady == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RotationReady);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRotationReady = matcher;
            }

            return _matcherRotationReady;
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

    static readonly Code.Gameplay.Features.RotationReady rotationReadyComponent = new Code.Gameplay.Features.RotationReady();

    public bool isRotationReady {
        get { return HasComponent(GameComponentsLookup.RotationReady); }
        set {
            if (value != isRotationReady) {
                var index = GameComponentsLookup.RotationReady;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : rotationReadyComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}