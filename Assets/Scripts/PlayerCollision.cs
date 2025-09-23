using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Vector2 respawnPoint;
    private int coinCount = 0;

    private void Start()
    {
        // Respawn point initialized (checkpoints included)
        respawnPoint = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Triggers when player picks up a coin and counts it each time. Disappears once collected
        if (other.CompareTag("Collectible"))
        {
            coinCount++;
            Destroy(other.gameObject);
            Debug.Log("Coins: " + coinCount);
        }

        // Deathzone triggers when player falls off of a platform
        if (other.CompareTag("DeathZone"))
        {
            transform.position = respawnPoint;
            Debug.Log("Player fell off the map! Respawning...");
        }
        else if (other.CompareTag("Checkpoint"))
        {
            // Updates new spawn point (checkpoint)
            respawnPoint = other.transform.position;
            Debug.Log("Checkpoint reached!");
        }
    }

    public void BuyPotion()
    {
        if (coinCount >= 5) // Potion costs 5 coins
        {
            coinCount -= 5;
            Debug.Log("Potion has been purchased! Only " + coinCount + "left");
        }
        else
        {
            Debug.Log("You need more coins!");
        }
    }
}
