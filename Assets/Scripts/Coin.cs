using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinCurrency currency = other.GetComponent<CoinCurrency>();
            if (currency != null)
            {
                currency.AddCoins(coinValue);
            }

            Destroy(gameObject); // Coin disappears once collected
        }
    }
}

