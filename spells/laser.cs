using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spellLaser : MonoBehaviour
{
    //References the point where the laser appears
    public Transform firePoint;
    //Gives visuals to the laser
    public GameObject impactEffect;
    //Laser damage
    public int damage = 10;
    //References the laser shot
    public laserRenderer laserRenderer;

    void Update()
    {
        //Checks if the player presses the shoot button. If it does, runs Shoot script
        if (Input.GetButtonDown("Fire2"))
        {
            //StartCoroutine is because Shoot is an IEnumerator. IEnumerator is needed to wait a frame
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        //Makes the laser appear from the player
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);

        if (hitInfo)
        {
            //Stores the info of the enemy on hit
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            //Enemy takes damage
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            //On hit, gives a different effect (Quaternion means no rotation)
            Instantiate(impactEffect, hitInfo.point, Quaternion.identity);

            //Start position of the laser
            laserRenderer.SetPosition(0, firePoint.position);
            //End position of laser on hit
            laserRenderer.SetPosition(1, hitInfo.point);
        }
        else
        {
            //Start position of the laser
            laserRenderer.SetPosition(0, firePoint.position);
            //Makes it look like the laser goes on endlessly
            laserRenderer.SetPosition(1, firePoint.position + firePoint.right * 100);

        }

        //Makes the laser visible
        laserRenderer.enabled = true;

        //Waits 1 frame
        yield return new WaitForSeconds(0.02f);

        //Makes the laser invisible
        laserRenderer.enabled = false;
    }
}

public class laserShot : MonoBehaviour
{
    //The speed of the 
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