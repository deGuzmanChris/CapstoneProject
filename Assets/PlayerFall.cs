using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFall : MonoBehaviour
{
    public Vector2 respawnPoint; //Starting position for player
    
    void Start()
    {
        respawnPoint = transform.position; //Spawn point initialized
    }

    private void nTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DeathZone"))
        {
            //Player position is reset
            transform.position = respawnPoint;
            Debug.Log("Player fell off! Resetting position");
        }
    }
}
