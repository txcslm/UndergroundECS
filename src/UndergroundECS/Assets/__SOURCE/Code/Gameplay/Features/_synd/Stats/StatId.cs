using System;
using System.Collections.Generic;
using System.Linq;

namespace Code.Gameplay.Features.Stats
{
  public enum StatId
  {
    Unknown = 0,

    WalkSpeed = 1,
  }

  public static class InitStats
  {
    public static Dictionary<StatId, float> EmptyStatDictionary()
    {
      return Enum.GetValues(typeof(StatId))
        .Cast<StatId>()
        .Except(new[] { StatId.Unknown })
        .ToDictionary(x => x, _ => 0f);
    }
  }
}