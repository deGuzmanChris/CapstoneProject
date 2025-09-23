using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1; // Coin is worth 1 credit towards the shop

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinCurrency currency = other.GetComponent<CoinCurrency>();
            if (currency != null)
            {
                currency.AddCoins(coinValue); // Adds up to the coinValue tally each time it's collected
            }

            Destroy(gameObject); // Coin disappears once collected
        }
    }
}

