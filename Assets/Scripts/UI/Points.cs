using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    public int points = 0;
    public Text text; 
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        text.text = points.ToString(); 
    }
}
