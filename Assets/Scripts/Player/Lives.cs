using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    // Start is called before the first frame update
    public int lives = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            SceneManager.LoadScene("Scenes/" + "Menu");
        }
    }
}
