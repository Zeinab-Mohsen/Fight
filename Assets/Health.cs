using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Animator animator;
    private int health = 100;
    private int currenthealth;

    void Start()
    {
        currenthealth = health;
    }

    public void Damage(int damage)
    {
        currenthealth -= damage;
        animator.SetTrigger("hurt");

        if (currenthealth <= 0)
        {
            animator.SetBool("dead",true);
        }
    }

}
