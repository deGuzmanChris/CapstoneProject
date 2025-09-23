using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth = 10f;
    private float currentHealth;

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
            Die();
        }
    }
    // Enemy is removed from the scene
    private void Die()
    {
        Debug.Log("Enemy died!");
        Destroy(gameObject); 
    }
}