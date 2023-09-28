

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Hero : MonoBehaviour
{

    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private InputActionAsset inputAsset;
    private InputActionMap player;
    private InputAction move;

    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        groundCheck = GetComponent<Transform>();

        inputAsset = this.GetComponent<PlayerInput>().actions;
        player = inputAsset.FindActionMap("Player");
    }

    void Update()
    {
        if (!isFacingRight && horizontal > 0f)
        {
            Flip();
        }
        else if (isFacingRight && horizontal < 0f)
        {
            Flip();
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower * 0.7f);
        }

        if (context.canceled && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private bool IsGrounded()
    {
        //Debug.Log("[eq");
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
        return collider.Length > 1;
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }



}



//private float speed = 3f;
//private int lives = 5;
//private float jumpForce = 15f;
//private bool isGrounded = false;

//private Rigidbody2D rb;
//private SpriteRenderer sprite;

//public static Hero Instance { get; set; }

//private void Awake()
//{
//    rb = GetComponent<Rigidbody2D>();
//    sprite = GetComponentInChildren<SpriteRenderer>();

//}

//private void Run()
//{
//    Vector3 dir = transform.right * Input.GetAxis("Horizontal");
//    transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

//}

//private void Update()
//{
//    if(Input.GetButton("Horizontal"))
//        nRun();
//    if (isGrounded && Input.GetButtonDown("Jump"))
//        Jump();
//}

//private void nRun()
//{
//    Vector3 dir = transform.right * Input.GetAxis("Horizontal");
//    transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
//    sprite.flipX = dir.x < 0.0f;

//}

//private void Jump()
//{
//    rb.AddForce(transform.up * jumpForce * 0.5f, ForceMode2D.Impulse);

//}

//private void CheckGround()
//{
//    Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
//    isGrounded = collider.Length > 1;

//}

//private void FixedUpdate()
//{
//    CheckGround();
//}

//public  void GetDamage()
//{
//    lives -= 1;
//    Debug.Log(lives);
//}







//public Rigidbody2D rb;
//public Transform groundCheck;
//public LayerMask groundLayer;

//private float horizontal;
//private float speed = 8f;
//private float jumpingPower = 16f;
//private bool isFacingRight = true;

//void Update()
//{
//    if (!isFacingRight && horizontal > 0f)
//    {
//        Flip();
//    }
//    else if (isFacingRight && horizontal < 0f)
//    {
//        Flip();
//    }
//}

//private void FixedUpdate()
//{
//    rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
//}

//public void Jump(InputAction.CallbackContext context)
//{
//    if (context.performed && IsGrounded())
//    {
//        rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
//    }

//    if (context.canceled && rb.velocity.y > 0f)
//    {
//        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
//    }
//}

//private bool IsGrounded()
//{
//    return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
//}

//private void Flip()
//{
//    isFacingRight = !isFacingRight;
//    Vector3 localScale = transform.localScale;
//    localScale.x *= -1f;
//    transform.localScale = localScale;
//}

//public void Move(InputAction.CallbackContext context)
//{
//    horizontal = context.ReadValue<Vector2>().x;
//}



//[SerializeField]
//private float playerSpeed = 2.0f;
//[SerializeField]
//private float jumpHeight = 1.0f;
//[SerializeField]
//private float gravityValue = -9.81f;

//private CharacterController controller;
//private Vector2 playerVelocity;
//private bool groundedPlayer;

//private Vector2 movmentInput = Vector2.zero;
//private bool jumped = false;

//private void Start()
//{
//    controller = gameObject.GetComponent<CharacterController>();
//}

//public void OnMove(InputAction.CallbackContext context)
//{
//    movmentInput = context.ReadValue<Vector2>();
//}

//public void OnJump(InputAction.CallbackContext context)
//{
//    jumped = context.action.triggered;
//}

//public void Update()
//{
//    groundedPlayer = controller.isGrounded;
//    if (groundedPlayer && playerVelocity.y < 0)
//    {
//        playerVelocity.y = 0f;
//    }

//    Vector2 move = new Vector2(movmentInput.x, movmentInput.y);
//    controller.Move(move * Time.deltaTime * playerSpeed);

//    if (jumped && groundedPlayer)
//    {
//        playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
//    }

//    playerVelocity.y = gravityValue * Time.deltaTime;
//    controller.Move(playerVelocity * Time.deltaTime);
//}










//public Rigidbody2D theRB;
//public float moveSpeed, jumpForce;

//public Transform groundPoint;
//public LayerMask whatIsGround;

//private bool isGrounded;
//private float inputX;

//private void Start()
//{
//    theRB = GetComponent<Rigidbody2D>();
//}

//private void Update()
//{
//    theRB.velocity = new Vector2(inputX * moveSpeed, theRB.velocity.y);

//    //isGrounded = Physics2D.OverlapCircle(groundPoint.position, .2f, whatIsGround);


//    if (theRB.velocity.x > 0f)
//    {

//        transform.localScale = Vector3.one;

//    }
//    else if (theRB.velocity.x < 0f)
//    {
//        transform.localScale = new Vector3(-1f, 1f, 1f);
//    }

//}

//public void Move(InputAction.CallbackContext context)
//{
//    Debug.Log("[eq");
//    inputX = context.ReadValue<Vector2>().x;

//}