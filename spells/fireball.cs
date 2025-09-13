using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spellFireball : MonoBehaviour
{
    //References the point where the fireball appears
    public Transform firePoint;
    //What type of shot the fireball is
    public GameObject fireballPrefab;

    void Update()
    {
        //Checks if the player presses the shoot button. If it does, runs Shoot script
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //Makes the fireball appear from the player
        Instantiate(fireballPrefab, firePoint.position, firePoint.rotation);
    }
}

public class fireballShot : MonoBehaviour
{
    //The speed of the fireball
    public float speed = 10f;
    //fireball damage
    public int damage = 5;
    //Makes reference to the player sprite
    public Rigidbody2D rb;
    public GameObject impactEffect;

    //Makes the fireball go in the direction it is facing.
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    //Collision checker
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Grabs enemy info and stores it inside a temporary object
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            //reduces health on hit
            enemy.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);
        //If it collides with target, destroys itself
        Destroy(gameObject);
    }
}

//Note: Please make the player rotate when changing directions. Or else the fireball will always go towards the right side of the screen if it is flipped.