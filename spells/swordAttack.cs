using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class swordAttack : MonoBehaviour
{

    //References the attack hitbox on unity
    public Transform swordAttack;
    //Range of the sword attack
    public float attackRange = 0.4f;
    //Finds the enemy layer in case of overlapping collisions
    public LayerMask enemyLayerMask;
    //Sword damage
    public int swordDamage = 10;
    //Sword cooldown
    public float cooldown = 1f;
    //Stores the time since last attack and its cooldown
    public float nextSwordAttack = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Time.time > nextSwordAttack)
        {
            //Checks how long since the spell fired. (Time.time is a float that tracks the time since its activation)
            nextSwordAttack = Time.time + cooldown;  
            Attack();
        }
    }

    void Attack()
    {
        //Returns the array of all colliders inside the transform point into a temporary array
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(swordAttack.position, attackRange, enemyLayerMask);

        foreach (Collider2D enemy in hitEnemies)
        {
            if (enemy != null)
            {
            //reduces health on hit
            enemy.GetComponent<Enemy>().TakeDamage(swordDamage);
            }
        }
    }

    //Purely meant for debugging, checks the size of the attack hitbox
    void OnDrawGizmosSelected()
    {
        //If the float isn't assigned, makes sure we don't get errors.
        if (swordAttack == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(swordAttack.position, attackRange);
    }
}