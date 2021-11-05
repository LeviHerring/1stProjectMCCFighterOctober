using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rigidBody;
    SpriteRenderer spriteRenderer;
    public Animator animator;
    bool isAttacking = false; 
    public float runSpeed = 6f;
    public float jumpHeight = 5f;
    float delay = 1f; 


    public bool IsGrounded;


    [SerializeField]
    Transform groundCheckCentre;
    [SerializeField]
    Transform groundCheckL;
    [SerializeField]
    Transform groundCheckR;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P) && !isAttacking)
        {
           
        }
        if(Input.GetKey(KeyCode.W) && !isAttacking)
        {
            if(Input.GetKey(KeyCode.P) && !isAttacking)
            {
               
            }
        }

      
     }

  

    private void FixedUpdate()
    {
        if((Physics2D.Linecast(transform.position, groundCheckCentre.position, 1 << LayerMask.NameToLayer("Wall"))) ||
            (Physics2D.Linecast(transform.position, groundCheckCentre.position, 1 << LayerMask.NameToLayer("Wall"))) ||
            (Physics2D.Linecast(transform.position, groundCheckCentre.position, 1 << LayerMask.NameToLayer("Wall"))))

        {
            IsGrounded = true;
            animator.SetBool("IsJumping", false); 
        }
        else
        {
            IsGrounded = false;
            animator.SetBool("IsJumping", true);
        }
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rigidBody.velocity = new Vector2(runSpeed, rigidBody.velocity.y);
            if (IsGrounded == true)
            {
                animator.SetFloat("Speed", 1f);
            }

         
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rigidBody.velocity = new Vector2(-runSpeed, rigidBody.velocity.y);
            if (IsGrounded == true)
            {
                animator.SetFloat("Speed", 1f);
            }


            spriteRenderer.flipX = true; 
        }
        else
        {
            if (IsGrounded == true)
            {
                animator.SetFloat("Speed", 0f);
                animator.SetBool("IsJumping", false); 
            }
            
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);

        }

        if (Input.GetKey("space") && IsGrounded == true)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpHeight);
            animator.SetBool("IsJumping", true); 
        }
        else
        {
            
        }
    }

    public void Attack(float delay)
    {
        Debug.Log("attack");
    }

    public void UpAttack(float delay)
    {
        Debug.Log("Up attack"); //ienumerators don't work but functions work. and ienumeratiors don't work inside functions
    }



}

