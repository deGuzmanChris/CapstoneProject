using UnityEngine;

public class Shopkeeper : MonoBehaviour
{
    public GameObject shopScreen; // Shop Screen UI panel will be dragged here
    private bool playerInRange = false;

    
    void Update()
    {
        // Shop screen UI pops up if player is in range and presses 'E'
        if (playerInRange && !shopScreen.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            shopScreen.SetActive(true); 
        }

        // Shop screen UI disappears if player presses 'Escape' while shop screen is still up
        if (shopScreen.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            shopScreen.SetActive(false);
        }
    }

    //Triggers condition for accessing shop screen when player is close enough to the shop
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerInRange = true;
    }

    //Otherwise, condition doesn't trigger when player is too far from range
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;

            // Shop screen closes automatically once player leaves range 
            if (shopScreen.activeSelf)
            {
                shopScreen.SetActive(false);
            }
        }
    }
}
