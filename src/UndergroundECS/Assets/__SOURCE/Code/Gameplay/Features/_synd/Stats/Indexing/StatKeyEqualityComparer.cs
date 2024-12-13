using System;
using System.Collections.Generic;

namespace Code.Gameplay.Features.Stats.Indexing
{
  public class StatKeyEqualityComparer : IEqualityComparer<StatKey>
  {
    public bool Equals(StatKey x, StatKey y)
    {
      return x.TargetId == y.TargetId && x.Stat == y.Stat;
    }

    public int GetHashCode(StatKey obj)
    {
      return HashCode.Combine(obj.TargetId, (int)obj.Stat);
    }
  }
}