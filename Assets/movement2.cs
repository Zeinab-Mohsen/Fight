using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movement2 : MonoBehaviour
{
  
    public Rigidbody2D body;
    public float move_speed = 10;
    public float jumpForce = 500;
    public Animator animator;
    public  static int health = 15;
    public Slider healthbar;
    bool iscollied = false;
    movement move1;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            iscollied = true;

        }
       
    }

    public void Take_Damage()
    {
        health--;
    }


    private void Update()
    {
        healthbar.value = health;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.position += new Vector3(1, 0, 0) * move_speed * Time.deltaTime;
            animator.SetBool("run", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0) * move_speed * Time.deltaTime;
            animator.SetBool("run", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            animator.SetBool("run", false);
        }


        if (Input.GetKeyDown(KeyCode.UpArrow) )
        {
            body.AddForce(new Vector3(0, jumpForce, 0));
            animator.SetTrigger("jump");
        }


        if (Input.GetKey(KeyCode.RightAlt))
        {
            animator.SetTrigger("attack");
            if (iscollied)
            {
                Take_Damage();              
            }       
            iscollied = false;
        }


        if (movement.health == 0)
        {
            animator.SetBool("dead2", true);
            SceneManager.LoadScene(2);
            movement.health = 15;
            movement2.health = 15;
        }
    }
}
   