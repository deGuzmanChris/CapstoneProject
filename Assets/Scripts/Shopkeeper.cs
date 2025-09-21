using UnityEngine;

public class Shopkeeper : MonoBehaviour
{
    private bool playerInRange = false;

    void Update()
    {
        // Player presses E near the shopkeeper (no UI yet, just log)
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Player is interacting with the shopkeeper!");
            // Later: show shop UI here
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player entered shop range");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Player left shop range");
        }
    }
}

