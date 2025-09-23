using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spellFireball : MonoBehaviour
{
    //References the point where the fireball appears
    public Transform firePoint;
    //What type of shot the fireball is
    public GameObject fireballPrefab;
    //How long until next fireball
    private float cooldown = 5f;
    //The float to freeze the time of shot + cooldown
    private float nextFireball = 0f;

    void Update()
    {
        //Checks if the player presses the shoot button and if the spell is off cooldown. If it does, runs Shoot script
        if (Input.GetButtonDown("Fire2") && Time.time > nextFireball)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //Checks how long since the spell fired. (Time.time is a float that tracks the time since its activation)
        nextFireball = Time.time + cooldown;
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

