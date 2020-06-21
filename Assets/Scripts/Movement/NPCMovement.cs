using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D npc;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WalkAround());
    }
    IEnumerator WalkAround()
    {
        int direction = Random.Range(0, 2);
        if (direction == 0)
        {
            npc.AddForce(new Vector2(10, 0));
        }
        else if (direction == 1)
        {
            npc.AddForce(new Vector2(-10, 0));
        }
        if (npc.velocity.x > 0)
        {
            npc.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            npc.GetComponent<SpriteRenderer>().flipX = true;
        }
        yield return new WaitForSeconds(5);
    }
}
