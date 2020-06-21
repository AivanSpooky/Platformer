using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    public int color_type = 1;
    bool key_picked_up = false;
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
        GameObject[] KeyDoors = GameObject.FindGameObjectsWithTag("KeyDoor");
        foreach (GameObject KeyDoor in KeyDoors)
        {
            UnityEngine.Debug.Log(KeyDoor.GetComponent<KeyDoor>().color_type);
            if (KeyDoor.GetComponent<KeyDoor>().color_type == color_type)
            {
                FindObjectOfType<AudioManager>().Play("takekey");
                KeyDoor.GetComponent<KeyDoor>().is_door_opened = true;
                Destroy(gameObject);
            }
            
        }
    }
}
