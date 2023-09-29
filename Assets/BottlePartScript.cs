using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottlePartScript : MonoBehaviour
{
    public SoundEffectPlayer soundEffectPlayer;
    public AudioClip bottleCollisionClip;
    private int frameCount = 0;
    private int frameColiisionCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        soundEffectPlayer = GameObject.FindWithTag("Sound").GetComponent<SoundEffectPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        frameCount++;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (frameColiisionCount != frameCount - 1)
        {
            soundEffectPlayer.Play(bottleCollisionClip);
        }
        frameColiisionCount = frameCount;
    }
}
