using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    bool IsDebugMode = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!IsDebugMode)
        {
            HideTriggers("Ground");
            HideTriggers("Wall");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            print("Escape pressed");
            SceneManager.LoadScene("Scenes/" + "Menu");
        }
    }
    
    void HideTriggers(string triggerType)
    {
        GameObject[] Triggers = GameObject.FindGameObjectsWithTag(triggerType);
        foreach (GameObject Trigger in Triggers)
        {
            Trigger.GetComponent<SpriteRenderer>().color = Color.clear;
        }
        Debug.Log(Triggers);
    }
}
