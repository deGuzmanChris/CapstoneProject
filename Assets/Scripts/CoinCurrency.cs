using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoinCurrency : MonoBehaviour
{
    public int coinCount = 0; // Coin count is shown here
    public TMP_Text coinText;
    void Start()
    {
        
    }
    void Update()
    {
        coinText.text = "Coins: x" + coinCount.ToString();
    }
    public void AddCoins(int amount)
    {
        coinCount += amount;
        Debug.Log(coinCount + "coins");
    }

    // For buying coins in the shop
    public bool SpendCoins(int amount)
    {
        if (coinCount >= amount)
        {
            coinCount -= amount;
            Debug.Log("Item purchased! Only " + coinCount + "coins left");
            return true;
        }
        else
        {
            Debug.Log("You need more coins!");
            return false;
        }
    }
    


}
