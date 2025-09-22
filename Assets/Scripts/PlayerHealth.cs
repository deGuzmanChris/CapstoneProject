using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxPlayerHealth = 50f;
    private float currentPlayerHealth;


    void Start()
    {
        currentPlayerHealth = maxPlayerHealth;
    }


}
