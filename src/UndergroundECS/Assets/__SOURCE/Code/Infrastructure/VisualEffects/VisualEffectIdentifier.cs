using UnityEngine;

namespace Code.Infrastructure.VisualEffects
{
  public class VisualEffectIdentifier : MonoBehaviour
  {
    [field: SerializeField] public VisualEffectId Id { get; private set; }
  }
}