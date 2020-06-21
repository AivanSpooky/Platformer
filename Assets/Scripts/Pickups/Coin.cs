using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Coin : MonoBehaviour
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
        if (col.tag != "Player")
        {
            return;
        }
        FindObjectOfType<AudioManager>().Play("takecoin");
        Destroy(gameObject);
        GameObject Points = GameObject.FindWithTag("Points");
        Points.GetComponent<Points>().points += 100;
    }
}
