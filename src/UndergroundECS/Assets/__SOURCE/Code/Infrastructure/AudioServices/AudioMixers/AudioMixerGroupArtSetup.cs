using System;
using UnityEngine;
using UnityEngine.Audio;

namespace Code.Infrastructure.AudioServices.AudioMixers
{
  [Serializable]
  public class AudioMixerGroupArtSetup : ArtSetup<AudioMixerGroupId>
  {
    public AudioMixerGroup AudioMixerGroup;

    [Range(0, 10f)] 
    [Tooltip("Минимальное время воспроизведения следующего звука")]
    public float Cooldown;
    
    [Range(1, 50)]
    [Tooltip("Количество аудиосорсов в пуле")]
    public int Count;

    public bool Loop;
  }
}