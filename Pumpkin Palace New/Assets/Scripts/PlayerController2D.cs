using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    //player stats
    public float speed;
    public float jumpForce;
    private float moveInput;

    //player rigidbody
    private Rigidbody2D rb;
    private bool isFacingRight = true;

    //player jump
    private bool isGrounded = true;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public bool doubleJump;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once  per set amount of frames
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(!isFacingRight && moveInput > 0)
        {
            FlipPlayer();
        }

        else if(isFacingRight && moveInput < 0)
        {
            FlipPlayer();
        }
    }

    void Update()
    {
        if(isGrounded)
        {
            doubleJump = true;
        }
        
        if(Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            rb.velocity = Vector2.up * jumpForce;//makes player jump
            doubleJump = false;
        }
        
        if(Input.GetKeyDown(KeyCode.Space) && !doubleJump && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void FlipPlayer()
    {
        isFacingRight = !isFacingRight;
        Vector3 scaler = transform.localScale;//local variable that stores localscale value
        scaler.x *= -1; //flip the sprite
        transform.localScale = scaler;
    }
}
