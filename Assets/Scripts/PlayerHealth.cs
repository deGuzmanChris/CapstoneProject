using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;   
public class PlayerHealth : MonoBehaviour
{
    public float maxPlayerHealth = 50f;
    public float currentPlayerHealth;
    public Image healthBar;
    void Start()
    {
        currentPlayerHealth = maxPlayerHealth;
    }
    void Update()
    {
        //healthBar.fillAmount = currentPlayerHealth;
        healthBar.fillAmount = Mathf.Clamp(currentPlayerHealth / maxPlayerHealth, 0, 1);
        if (Input.GetKeyDown(KeyCode.O))
        {
            TakeDamage(10);
            Debug.Log("Player Health: " + currentPlayerHealth);
        }

        if (currentPlayerHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    void TakeDamage(int damage)
    {
        currentPlayerHealth -= damage;
       
    }


}
//reference:https://www.youtube.com/watch?v=BLfNP4Sc_iA 