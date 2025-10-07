using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 10f;      // Speed of the fireball
    public float lifetime = 0.5f;    // Fireball disappears after 2 seconds 
    public int damage = 2;         // Fireball damage to enemy

    // References the player sprite
    private Rigidbody2D rb;

    // Fireball shoots in the direction it is facing
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Fireball moves to the right of firePoint's facing direction
        rb.linearVelocity = transform.right * speed;

        // Destroy automatically after lifetime
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // If fireball hits an enemy
        if (other.CompareTag("Enemy"))
        {
            // Grabs enemy info and stores it inside a temp object
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                // Reduces health on hit
                enemy.TakeDamage(damage);
            }

            // Fireball is destroyed after hitting an enemy
            Destroy(gameObject);
        }

        // If fireball hits ground or walls
        if (other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}