using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        anim = player.GetComponent<Animator>();
    }
    private Animator anim;
    bool is_ground = false;
    bool is_wall = false;
    bool is_doublejump = false;//переменная которая хранит в себе значение, "на земле ли игрок"
    public float force = 10;     //сила с которой будет прыгать персонаж

    void OnTriggerStay2D(Collider2D col)
    {               //если в тригере что то есть и у обьекта тег "ground"

        if (col.tag == "Ground")
        {
            is_ground = true;      //то включаем переменную "на земле"
        }
        if (col.tag == "Wall")
        {
            is_wall = true;      //то включаем переменную "на земле"
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {              //если из триггера что то вышло и у обьекта тег "ground"
        if (col.tag == "Ground")
        {
            is_ground = false;//то вЫключаем переменную "на земле"
        }
        if (col.tag == "Wall")
        {
            is_wall = false;     //то вЫключаем переменную "на земле"
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "OutOfMap")
        {
            GameObject PlayerLives = GameObject.FindWithTag("GameController");
            PlayerLives.GetComponent<Lives>().lives -= 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey("w"))
		//{
			//player.AddForce(new Vector2(0, 3));
		//}
        if (player.velocity.magnitude <= 8)
        {
            if (Input.GetKey("a"))
            {
                player.GetComponent<SpriteRenderer>().flipX = true;
                player.AddForce(new Vector2(-3, 0));
                anim.SetBool("IsRunning", true);
            }
            if (Input.GetKey("d"))
            {
                player.GetComponent<SpriteRenderer>().flipX = false;
                player.AddForce(new Vector2(3, 0));
                anim.SetBool("IsRunning", true);
            }
            if (!Input.GetKey("a") && !Input.GetKey("d"))
            {
                anim.SetBool("IsRunning", false);
            }    
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (is_ground)
            {
                player.AddForce(Vector2.up * force, ForceMode2D.Impulse);
                FindObjectOfType<AudioManager>().Play("jump");//то придаем ему силу вверх импульсным пинком
                is_doublejump = true;
            }
            else if (is_doublejump && !is_wall)
            {
                player.AddForce(Vector2.up * (force - 1), ForceMode2D.Impulse);
                FindObjectOfType<AudioManager>().Play("jump");//то придаем ему силу вверх импульсным пинком
                is_doublejump = false;
            }
            else if (is_doublejump && is_wall)
            {
                player.AddForce(Vector2.up * (force + 3), ForceMode2D.Impulse);
                FindObjectOfType<AudioManager>().Play("jump");//то придаем ему силу вверх импульсным пинком
                is_doublejump = false;
            }
        }
        if (Input.GetKey("z"))
        {
            StartCoroutine(slash());
        }
    }
    IEnumerator slash()
    {
        anim.SetBool("IsSlash", true);
        yield return new WaitForSeconds(0.22f);
        UnityEngine.Debug.Log("slash");
        anim.SetBool("IsSlash", false);
    }
}
