﻿using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Stats;
using Code.Gameplay.Features.Stats.Indexing;
using Entitas;
using Zenject;

namespace Code.Common.EntityIndices
{
  public class GameEntityIndices : IInitializable
  {
    private readonly GameContext _game;

    public const string StatusesOfType = "StatusesOfType";
    public const string StatChanges = "StatChanges";

    public GameEntityIndices(GameContext game)
    {
      _game = game;
    }

    public void Initialize()
    {
      _game.AddEntityIndex(new EntityIndex<GameEntity, StatKey>(
        name: StatChanges,
        _game.GetGroup(GameMatcher.AllOf(
          GameMatcher.StatChange,
          GameMatcher.TargetId)),
        getKey: GetTargetStatKey,
        new StatKeyEqualityComparer()));
    }

    private StatKey GetTargetStatKey(GameEntity entity, IComponent component)
    {
      return new StatKey(
        (component as TargetId)?.Value ?? entity.TargetId,
        (component as StatChange)?.Value ?? entity.StatChange);
    }
  }

  public static class ContextIndicesExtensions
  {
    public static HashSet<GameEntity> TargetStatChanges(this GameContext context, StatId stat, int targetId)
    {
      return ((EntityIndex<GameEntity, StatKey>)context.GetEntityIndex(GameEntityIndices.StatChanges))
        .GetEntities(new StatKey(targetId, stat));
    }
  }
}