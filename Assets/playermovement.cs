using UnityEngine;

public class playermovement : MonoBehaviour
{
    private Rigidbody2D body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    { //moves player left and right
        body.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * 10 , body.linearVelocityY);
        //makes player jump
        if (Input.GetKeyDown(KeyCode.W))
        {
            body.AddForce(new Vector2(0, 500));
        }
    }
}
