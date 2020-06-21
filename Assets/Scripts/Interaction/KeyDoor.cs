using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public bool is_door_opened = false;
    public int color_type = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (is_door_opened == true)
        {
            Destroy(gameObject);
        }
    }
}
