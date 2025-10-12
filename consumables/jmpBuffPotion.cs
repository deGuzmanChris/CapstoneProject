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
            //Gets JMP value into an int
            int currentJMP = statsGetter.GetTotalJMP();
            //Adds buff amount to current JMP
            int buffedJMP = currentJMP + buffAmount;
            float spellStart = Time.time;

            //Sets player JMP to new buffed amount
            GameObject playerObj = GameObject.FindWithTag("Player");
            if (playerObj != null)
            {
                totalPlayerStats player = playerObj.GetComponent<totalPlayerStats>();
                if (player != null)
                {
                    player.SetTotalJMP(buffedJMP);
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
                            player.SetTotalJMP(currentJMP);
                        }
                    }
                    break;
                }
            }
        }
    }
}