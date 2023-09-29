using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
    public AudioSource src;

    public void Play(AudioClip clip)
    {
        src.clip = clip;
        src.Play();
    }
}
