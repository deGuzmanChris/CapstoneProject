using UnityEngine;

public class playermovement : MonoBehaviour
{
    private Rigidbody2D body;
    private bool grounded;
    private Vector2 respawnPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        // Respawn point initialized (checkpoints included)
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        //moves player left and right
        body.linearVelocity = new Vector2(horizontalInput * 10, body.linearVelocityY);
        //flips player sprite based on direction
        if (horizontalInput > 0.01f)//moves right
        {
            transform.localScale = new Vector3(2, 2, 2);
        }
        else if (horizontalInput < -0.01f)//moves left
        {
            transform.localScale = new Vector3(-2, 2, 2);
        }
        //makes player jump
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            Jump();
        }
    }
    
    private void Jump()//this will let player jump only if grounded is true
    {
        grounded = false;
        body.AddForce(new Vector2(0, 300));
        
    }
    private void OnCollisionEnter2D(Collision2D collision)//this will check if player is on the ground and will return true if player is touching the ground
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded =true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)//This is for the deathzone collision when player falls off of a platform
    {
        if (other.CompareTag("DeathZone"))
        {
            transform.position = respawnPoint;
            Debug.Log("Player fell off the map! Respawning...");
        }
        else if (other.CompareTag("Checkpoint"))
        {
            respawnPoint = other.transform.position;//Updates new spawn point (checkpoint)
            Debug.Log("Checkpoint reached!");
        }
    }
}
