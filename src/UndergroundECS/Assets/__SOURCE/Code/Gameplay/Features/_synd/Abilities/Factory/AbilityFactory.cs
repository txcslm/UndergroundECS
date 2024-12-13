// ReSharper disable UnusedType.Global

namespace Code.Gameplay.Features.Abilities.Factory
{
  public class AbilityFactory
  {
    // private readonly IIdentifierService _identifiers;
    // private readonly IStaticDataService _staticDataService;
    //
    // public AbilityFactory(IIdentifierService identifiers, IStaticDataService staticDataService)
    // {
    //   _identifiers = identifiers;
    //   _staticDataService = staticDataService;
    // }

    // public GameEntity CreateVegetableBoltAbility(int level)
    // {
    //   AbilityLevel abilityLevel = _staticDataService.GetAbilityLevel(AbilityId.VegetableBolt, level);
    //   
    //   return CreateEntity.Empty()
    //     .AddId(_identifiers.Next())
    //     .AddAbilityId(AbilityId.VegetableBolt)
    //     .AddCooldown(abilityLevel.Cooldown)
    //     .With(x => x.isVegetableBoltAbility = true)
    //     .PutOnCooldown();
    // }
    //
    // public GameEntity CreateOrbitingMushroomAbility(int level)
    // {
    //   AbilityLevel abilityLevel = _staticDataService.GetAbilityLevel(AbilityId.OrbitingMushroom, level);
    //   
    //   return CreateEntity.Empty()
    //     .AddId(_identifiers.Next())
    //     .AddAbilityId(AbilityId.OrbitingMushroom)
    //     .AddCooldown(abilityLevel.Cooldown)
    //     .With(x => x.isOrbitingMushroomAbility = true)
    //     .With(x => x.isRecreatedOnUpgrade = true)
    //     .PutOnCooldown();
    //     ;
    // }
    //
    // public GameEntity CreateGarlicAuraAbility()
    // {
    //   return CreateEntity.Empty()
    //     .AddId(_identifiers.Next())
    //     .AddAbilityId(AbilityId.GarlicAura)
    //     .With(x => x.isGarlicAuraAbility = true)
    //     .With(x => x.isRecreatedOnUpgrade = true)
    //     ;
    // }
  }
}