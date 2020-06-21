using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    // Start is called before the first frame update
    public int when_heart_dissapear = 3;
    private Image image;
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject PlayerLives = GameObject.FindWithTag("GameController");
        var tempColor = image.color;
        tempColor.a = (PlayerLives.GetComponent<Lives>().lives < when_heart_dissapear) ? 0.2f : 1f;
        image.color = tempColor;
    }
}
