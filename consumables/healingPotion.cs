using UnityEngine;
using System.Collections;

public class healingPotion : items
{
    //Amount the potion heals
    int healAmount = 5;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            //Gets player object
            playerTotalStatsGetter statsGetter = new playerTotalStatsGetter();
            //Gets HP value into an int
            int currentHP = statsGetter.GetTotalHP();
            //Adds heal amount to current HP
            int healedHP = currentHP + healAmount;

            //Sets player HP to new healed amount
            totalPlayerStats player = GameObject.GetComponent<totalPlayerStats>();
        }
    }
}