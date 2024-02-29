using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class movement : MonoBehaviour
{
    
    public Rigidbody2D rp;
    public float move_direction;
    public float move_speed = 10;
    public float jumpForce = 500;
    public Animator animator;
    public static int health = 15;
    public Slider healthbar;
    bool iscollied = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
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
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * move_speed * Time.deltaTime;
            animator.SetBool("run", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0) * move_speed * Time.deltaTime;
            animator.SetBool("run", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            animator.SetBool("run", false);
        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            rp.AddForce(new Vector3(0, jumpForce, 0));
            animator.SetTrigger("jump");
        }


        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("attack");
            if (iscollied)
            {
                Take_Damage();               
            } 
            iscollied = false;
        }


        if (movement2.health == 0)
        {
            animator.SetBool("dead", true);
            SceneManager.LoadScene(3);
            movement.health = 15;
            movement2.health = 15;
        }
    }
}
