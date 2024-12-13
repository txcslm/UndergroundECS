//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherStatModifiers;

    public static Entitas.IMatcher<GameEntity> StatModifiers {
        get {
            if (_matcherStatModifiers == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.StatModifiers);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherStatModifiers = matcher;
            }

            return _matcherStatModifiers;
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

    public Code.Gameplay.Features.Stats.StatModifiers statModifiers { get { return (Code.Gameplay.Features.Stats.StatModifiers)GetComponent(GameComponentsLookup.StatModifiers); } }
    public System.Collections.Generic.Dictionary<Code.Gameplay.Features.Stats.StatId, float> StatModifiers { get { return statModifiers.Value; } }
    public bool hasStatModifiers { get { return HasComponent(GameComponentsLookup.StatModifiers); } }

    public GameEntity AddStatModifiers(System.Collections.Generic.Dictionary<Code.Gameplay.Features.Stats.StatId, float> newValue) {
        var index = GameComponentsLookup.StatModifiers;
        var component = (Code.Gameplay.Features.Stats.StatModifiers)CreateComponent(index, typeof(Code.Gameplay.Features.Stats.StatModifiers));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceStatModifiers(System.Collections.Generic.Dictionary<Code.Gameplay.Features.Stats.StatId, float> newValue) {
        var index = GameComponentsLookup.StatModifiers;
        var component = (Code.Gameplay.Features.Stats.StatModifiers)CreateComponent(index, typeof(Code.Gameplay.Features.Stats.StatModifiers));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveStatModifiers() {
        RemoveComponent(GameComponentsLookup.StatModifiers);
        return this;
    }
}
