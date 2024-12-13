//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCollectingTargetsContinuously;

    public static Entitas.IMatcher<GameEntity> CollectingTargetsContinuously {
        get {
            if (_matcherCollectingTargetsContinuously == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CollectingTargetsContinuously);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCollectingTargetsContinuously = matcher;
            }

            return _matcherCollectingTargetsContinuously;
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

    static readonly Code.Gameplay.Features.TargetCollection.CollectingTargetsContinuously collectingTargetsContinuouslyComponent = new Code.Gameplay.Features.TargetCollection.CollectingTargetsContinuously();

    public bool isCollectingTargetsContinuously {
        get { return HasComponent(GameComponentsLookup.CollectingTargetsContinuously); }
        set {
            if (value != isCollectingTargetsContinuously) {
                var index = GameComponentsLookup.CollectingTargetsContinuously;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : collectingTargetsContinuouslyComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
