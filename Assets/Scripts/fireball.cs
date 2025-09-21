using UnityEngine;

public class fireball : MonoBehaviour
{
    //The speed of the fireball
    public float speed = 10f;
    //fireball damage
    public int damage = 5;
    //Makes reference to the player sprite
    public Rigidbody2D rb;
    public GameObject impactEffect;

    //Makes the fireball go in the direction it is facing.
    public void Start()
    {
        rb.linearVelocity = transform.right * speed;
    }
    /*
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
    */
}

