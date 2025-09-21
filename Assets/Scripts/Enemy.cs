using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Health")]
    public float maxHealth = 10f;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(2f); // enemy loses 2 HP each time player presses a key input: 'Spacebar'
        }
    }

    // Call this from player attacks later
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        Debug.Log("Enemy took " + amount + " damage. Remaining health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died!");
        Destroy(gameObject); // removes enemy from the scene
    }
}

