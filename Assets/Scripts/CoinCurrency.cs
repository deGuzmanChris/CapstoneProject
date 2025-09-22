using UnityEngine;

public class CoinCurrency : MonoBehaviour
{
    public int coins = 0; // Coin count is shown here

    // Adds coins collected
    public void AddCoins(int amount)
    {
        coins += amount;
        Debug.Log(coins + "coins");
    }

    // For buying coins in the shop
    public bool SpendCoins(int amount)
    {
        if (coins >= amount)
        {
            coins -= amount;
            Debug.Log("Item purchased! Only " + coins + "coins left");
            return true;
        }
        else
        {
            Debug.Log("You need more coins!");
            return false;
        }
    }
}
