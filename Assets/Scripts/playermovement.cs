using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private bool grounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        // Moves player left and right
        body.linearVelocity = new Vector2(horizontalInput * 10, body.linearVelocityY);
        // Flips player sprite based on direction
        if (horizontalInput > 0.01f)//moves right
        {
            transform.localScale = new Vector3(2, 2, 2);
        }
        else if (horizontalInput < -0.01f)//moves left
        {
            transform.localScale = new Vector3(-2, 2, 2);
        }
        // Makes player jump
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            Jump();
        }
    }

    private void Jump()// This will let player jump only if grounded is true
    {
        grounded = false;
        body.AddForce(new Vector2(0, 300));
    }

    private void OnCollisionEnter2D(Collision2D collision)// This will check if player is on the ground and will return true if player is touching the ground
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}
