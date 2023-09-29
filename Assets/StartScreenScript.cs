using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScreenScript : MonoBehaviour
{
    public GameObject bottle;
    public GameObject spawnPipe;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bottle.GetComponent<Rigidbody2D>().isKinematic = false;
            spawnPipe.SetActive(true);
            gameObject.SetActive(false);
            scoreText.enabled = true;
        }
    }
}
