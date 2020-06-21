using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("fire");
            GameObject PlayerLives = GameObject.FindWithTag("GameController");
            PlayerLives.GetComponent<Lives>().lives -= 1;
        }
    }
}
