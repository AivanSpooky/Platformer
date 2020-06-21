using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
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
        GameObject Lives = GameObject.FindWithTag("GameController");
        if (col.tag != "Player" ||  Lives.GetComponent<Lives>().lives == 3)
        {
            return;
        }
        FindObjectOfType<AudioManager>().Play("takelive");
        Lives.GetComponent<Lives>().lives += 1;
        Destroy(gameObject);
    }
}
