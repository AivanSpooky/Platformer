using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    bool is_ground = false;
    bool is_doublejump = false; //переменная которая хранит в себе значение, "на земле ли игрок"
    Rigidbody2D player;         //так как мы часть обращаемся к физике, то не лишним будет закэшировать этот компонент
    public float force = 6;     //сила с которой будет прыгать персонаж

    void Start()
    {
        player = GetComponent<Rigidbody2D>(); //при старке сцены, получаем компонент и сохраняем в переменную
    }

    void OnTriggerStay2D(Collider2D col){               //если в тригере что то есть и у обьекта тег "ground"
        Debug.Log(col);
        if (col.tag == "Ground")
		{			
	        is_ground = true;      //то включаем переменную "на земле"
		}
    }
     void OnTriggerExit2D(Collider2D col){              //если из триггера что то вышло и у обьекта тег "ground"
        if (col.tag == "Ground")
		{
			is_ground = false;
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
            if (is_ground)
            {
                player.AddForce(Vector2.up * force, ForceMode2D.Impulse);   //то придаем ему силу вверх импульсным пинком
                is_doublejump = true;
            }
            else if (is_doublejump)
            {
                player.AddForce(Vector2.up * force, ForceMode2D.Impulse);   //то придаем ему силу вверх импульсным пинком
                is_doublejump = false;
            }
            print(is_doublejump);
        }
    }
}