using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private bool grounded;
    [SerializeField] private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        //moves player left and right
        body.linearVelocity = new Vector2(horizontalInput * 5, body.linearVelocityY);
        //flips player sprite based on direction
        if (horizontalInput > 0.01f)//moves right
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (horizontalInput < -0.01f)//moves left
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        //makes player jump
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            Jump();
        }
        if (horizontalInput != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
    
    private void Jump()//this will let player jump only if grounded is true
    {
        grounded = false;
        body.AddForce(new Vector2(0, 400));
        
    }
    private void OnCollisionEnter2D(Collision2D collision)//this will check if player is on the ground and will return true if player is touching the ground
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded =true;
        }
    }
    void onco
  
}
//note: https://docs.unity3d.com/6000.2/Documentation/ScriptReference/Quaternion.html
