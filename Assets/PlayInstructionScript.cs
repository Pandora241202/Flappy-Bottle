using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayInstructionScript : MonoBehaviour
{
    private float blinkRate = 0.5f;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > blinkRate * 2)
        {
            gameObject.GetComponent<Text>().enabled = true;
            timer = 0;
        }
        else if (timer > blinkRate)
        {
            gameObject.GetComponent<Text>().enabled = false;
        }
    }
}
