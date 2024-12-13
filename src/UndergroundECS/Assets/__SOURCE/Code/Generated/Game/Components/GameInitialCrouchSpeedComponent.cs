//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherInitialCrouchSpeed;

    public static Entitas.IMatcher<GameEntity> InitialCrouchSpeed {
        get {
            if (_matcherInitialCrouchSpeed == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.InitialCrouchSpeed);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInitialCrouchSpeed = matcher;
            }

            return _matcherInitialCrouchSpeed;
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

    public Code.Gameplay.Features.Movement.InitialCrouchSpeed initialCrouchSpeed { get { return (Code.Gameplay.Features.Movement.InitialCrouchSpeed)GetComponent(GameComponentsLookup.InitialCrouchSpeed); } }
    public float InitialCrouchSpeed { get { return initialCrouchSpeed.Value; } }
    public bool hasInitialCrouchSpeed { get { return HasComponent(GameComponentsLookup.InitialCrouchSpeed); } }

    public GameEntity AddInitialCrouchSpeed(float newValue) {
        var index = GameComponentsLookup.InitialCrouchSpeed;
        var component = (Code.Gameplay.Features.Movement.InitialCrouchSpeed)CreateComponent(index, typeof(Code.Gameplay.Features.Movement.InitialCrouchSpeed));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceInitialCrouchSpeed(float newValue) {
        var index = GameComponentsLookup.InitialCrouchSpeed;
        var component = (Code.Gameplay.Features.Movement.InitialCrouchSpeed)CreateComponent(index, typeof(Code.Gameplay.Features.Movement.InitialCrouchSpeed));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveInitialCrouchSpeed() {
        RemoveComponent(GameComponentsLookup.InitialCrouchSpeed);
        return this;
    }
}
