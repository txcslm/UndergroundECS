//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherStandingCenter;

    public static Entitas.IMatcher<GameEntity> StandingCenter {
        get {
            if (_matcherStandingCenter == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.StandingCenter);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherStandingCenter = matcher;
            }

            return _matcherStandingCenter;
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

    public Code.Gameplay.Features.Player.StandingCenter standingCenter { get { return (Code.Gameplay.Features.Player.StandingCenter)GetComponent(GameComponentsLookup.StandingCenter); } }
    public UnityEngine.Vector3 StandingCenter { get { return standingCenter.Value; } }
    public bool hasStandingCenter { get { return HasComponent(GameComponentsLookup.StandingCenter); } }

    public GameEntity AddStandingCenter(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.StandingCenter;
        var component = (Code.Gameplay.Features.Player.StandingCenter)CreateComponent(index, typeof(Code.Gameplay.Features.Player.StandingCenter));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceStandingCenter(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.StandingCenter;
        var component = (Code.Gameplay.Features.Player.StandingCenter)CreateComponent(index, typeof(Code.Gameplay.Features.Player.StandingCenter));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveStandingCenter() {
        RemoveComponent(GameComponentsLookup.StandingCenter);
        return this;
    }
}
