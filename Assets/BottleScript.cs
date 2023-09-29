using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public SoundEffectPlayer soundEffectPlayer;
    public bool alive = true;
    public AudioClip bottleCollisionClip, tappingClip;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.isKinematic = true;
        logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
        soundEffectPlayer = GameObject.FindWithTag("Sound").GetComponent<SoundEffectPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            logic.Restart();
        }

        if (alive && Input.GetKeyDown(KeyCode.Space))
        {
            soundEffectPlayer.Play(tappingClip);
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if (gameObject.transform.position.y * gameObject.transform.position.y > 36)
        {
            logic.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.BreakBottle();
        Destroy(gameObject);
        logic.GameOver();
        alive = false;
    }   
}
