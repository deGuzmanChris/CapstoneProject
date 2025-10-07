using UnityEngine;
using UnityEngine.UI;
public class Shopkeeper : MonoBehaviour
{
    private bool playerInRange = false;
    public CoinCurrency currency;
    public Text coinText;



    public void Update()
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

//references:https://www.themoderncoder.com/a-better-git-workflow-with-rebase/ how to rebase with github https://www.youtube.com/watch?v=f1wnYdLEpgI Learn Git Rebase
/* git merge- pulls in the most latest changes from main branch.this basically ties both the branches together, the main branch and my feature branch
 * git rebase- reapplies your changes on top of the main branch. so from the point where you branched off, it takes your changes and puts them on top of the latest main branch
 * 
*/
