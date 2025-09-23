using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth = 10f; // Enemy has 10 health points (hp)
    private float currentHealth; // Cannot be changed manually, only changes when damage is taken

    // Enemy starts out with max health
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Enemy takes damage from player
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("Enemy took " + damage + " damage. Remaining HP: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die(); // Calls out Die function once enemy takes enough damage from player
        }
    }
    // Enemy is removed from the scene
    private void Die()
    {
        Debug.Log("Enemy died!");
        Destroy(gameObject); // Destroys the enemy object from the scene once they die
    }
}