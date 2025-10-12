using UnityEngine;
using System.Collections;

public class healingPotion : items
{
    //Amount the potion buffs
    int buffAmount = 5;

    //Duration of the buff in seconds
    float buffDuration = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            //Gets player object
            playerTotalStatsGetter statsGetter = new playerTotalStatsGetter();
            //Gets ATK value into an int
            int currentATK = statsGetter.GetTotalATK();
            //Adds buff amount to current ATK
            int buffedATK = currentATK + buffAmount;
            float spellStart = Time.time;

            //Sets player ATK to new buffed amount
            GameObject playerObj = GameObject.FindWithTag("Player");
            if (playerObj != null)
            {
                totalPlayerStats player = playerObj.GetComponent<totalPlayerStats>();
                if (player != null)
                {
                    player.SetTotalATK(buffedATK);
                }
            }

            //Waits for buff duration to end
            while (Time.time < spellStart + buffDuration)
            {
                //Resets buff to original amount after duration
                if (Time.time >= spellStart + buffDuration)
                {
                    if (playerObj != null)
                    {
                        totalPlayerStats player = playerObj.GetComponent<totalPlayerStats>();

                        if (player != null)
                        {
                            player.SetTotalATK(currentATK);
                        }
                    }
                    break;
                }
            }
        }
    }
}