﻿using UnityEngine;

namespace Code.Gameplay.Features.Inputs
{
  [CreateAssetMenu(fileName = "Input", menuName = "Configs/Input")]
  public class InputConfig : ScriptableObject
  {
    [field: Header("Controls")]
    [field: SerializeField]
    public KeyCode SprintKey { get; private set; } = KeyCode.LeftShift;

    [field: SerializeField]
    public KeyCode JumpKey { get; private set; } = KeyCode.Space;

    [field: SerializeField]
    public KeyCode CrouchKey { get; private set; } = KeyCode.LeftControl;

    [field: SerializeField]
    public KeyCode InteractKey { get; private set; } = KeyCode.E;
  
    [field: SerializeField]
    public KeyCode ExitKey { get; private set; } = KeyCode.Escape;
  }
}