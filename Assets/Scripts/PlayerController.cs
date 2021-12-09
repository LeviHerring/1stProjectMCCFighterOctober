using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rigidBody;
    SpriteRenderer spriteRenderer;
    AnimationEvents animationEvents;
    public Animator animator;
    public bool isAttacking = false; 
    public float runSpeed = 6f;
    public float jumpHeight = 5f;
    public bool canDoubleJump;

    public bool IsGrounded;

    [SerializeField] GameObject forwarBasicHitbox;

    [SerializeField] GameObject downBasicHitbox;

    [SerializeField] GameObject upBasicHitbox;

    [SerializeField] GameObject forwardStrongHitbox;

    [SerializeField] GameObject downStrongHitbox;

    [SerializeField] GameObject upStrongHitbox;

    [SerializeField] GameObject forwardSpecialHitbox;

    [SerializeField] GameObject downSpecialHitbox;

    [SerializeField] GameObject upSpecialHitbox;

    [SerializeField] GameObject forwardBasicAirHitbox;

    [SerializeField] GameObject downBasicAirHitbox;

    [SerializeField] GameObject upBasicAirHitbox;

    [SerializeField] GameObject forwardStrongAirHitbox;

    [SerializeField] GameObject downStrongAirHitbox;

    [SerializeField] GameObject upStrongAirHitbox;




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
        animationEvents = GetComponent<AnimationEvents>();

    }

    // Update is called once per frame
    void Update()
    {
        if(IsGrounded)
        {
            if (Input.GetKey(KeyCode.P) && IsGrounded && GetComponent<AnimationEvents>().isAttacking == false)
            {
                Attack();
            }
            if (Input.GetKey(KeyCode.O) && IsGrounded && GetComponent<AnimationEvents>().isAttacking == false)
            {
                GetComponent<AnimationEvents>().isAttacking = true;
                forwardStrongAirHitbox.gameObject.SetActive(true);
                animator.SetBool("IsDown", false);
                animator.SetBool("IsAttacking", true);
                animator.SetBool("IsForward", true);
                animator.SetBool("IsStrong", true);
                animator.SetBool("IsSpecial", false);
            }
            if (Input.GetKey(KeyCode.I) && IsGrounded && GetComponent<AnimationEvents>().isAttacking == false)
            {
                forwardSpecialHitbox.gameObject.SetActive(true);
                GetComponent<AnimationEvents>().isAttacking = true;
                animator.SetBool("IsDown", false);
                animator.SetBool("IsAttacking", true);
                animator.SetBool("IsForward", true);
                animator.SetBool("IsStrong", false);
                animator.SetBool("IsSpecial", true);
            }
            if (Input.GetKey(KeyCode.W) && IsGrounded)
            {
                if (Input.GetKey(KeyCode.P))
                {
                    UpAttack();
                    //Debug.Log("Up attack"); 
                    //GetComponent<AnimationEvents>().isAttacking = true;
                    //animator.SetBool("IsUp", true);
                    //animator.SetBool("IsAttacking", true);
                    //animator.SetBool("IsForward", false);
                    //animator.SetBool("IsStrong", false);
                    //animator.SetBool("IsSpecial", false);

                }
                if (Input.GetKey(KeyCode.O))
                {
                    upStrongHitbox.gameObject.SetActive(true);
                    GetComponent<AnimationEvents>().isAttacking = true;
                    animator.SetBool("IsUp", true);
                    animator.SetBool("IsDown", false);
                    animator.SetBool("IsAttacking", true);
                    animator.SetBool("IsForward", false);
                    animator.SetBool("IsStrong", true);
                    animator.SetBool("IsSpecial", false);
                }
                if (Input.GetKey(KeyCode.I))
                {
                    upSpecialHitbox.gameObject.SetActive(true);
                    GetComponent<AnimationEvents>().isAttacking = true;
                    animator.SetBool("IsUp", true);
                    animator.SetBool("IsDown", false);
                    animator.SetBool("IsAttacking", true);
                    animator.SetBool("IsForward", false);
                    animator.SetBool("IsStrong", false);
                    animator.SetBool("IsSpecial", true);
                }
            }

            if (Input.GetKey(KeyCode.S) && IsGrounded)
            {
                if (Input.GetKey(KeyCode.P))
                {
                    downBasicHitbox.gameObject.SetActive(true);
                    animator.SetBool("IsDown", true);
                    animator.SetBool("IsAttacking", true);
                    animator.SetBool("IsForward", false);
                    animator.SetBool("IsStrong", false);
                    animator.SetBool("IsSpecial", false);
                }
                if (Input.GetKey(KeyCode.O))
                {
                    downStrongHitbox.gameObject.SetActive(true); 
                    animator.SetBool("IsDown", true);
                    animator.SetBool("IsAttacking", true);
                    animator.SetBool("IsForward", false);
                    animator.SetBool("IsStrong", true);
                    animator.SetBool("IsSpecial", false);
                }
                if (Input.GetKey(KeyCode.I))
                {
                    downSpecialHitbox.gameObject.SetActive(true); 
                    animator.SetBool("IsDown", true);
                    animator.SetBool("IsAttacking", true);
                    animator.SetBool("IsForward", false);
                    animator.SetBool("IsStrong", false);
                    animator.SetBool("IsSpecial", true);
                }
            }

        }
        else if (!IsGrounded)
        {
            if(Input.GetKey(KeyCode.P))
            {
                forwardBasicAirHitbox.gameObject.SetActive(true); 
                 animator.SetBool("IsJumping", true);
                animator.SetBool("IsAirAttacking", true);
                animator.SetBool("IsForward", true);
            }
            if (Input.GetKey(KeyCode.O))
            {
                forwardStrongAirHitbox.gameObject.SetActive(true); 
                animator.SetBool("IsJumping", true);
                animator.SetBool("IsAirAttacking", true);
                animator.SetBool("IsForward", true);
                animator.SetBool("IsStrong", true);
                animator.SetBool("IsSpecial", false); 
            }
            if (Input.GetKey(KeyCode.I))
            {
                forwardSpecialHitbox.gameObject.SetActive(true); 
                animator.SetBool("IsJumping", false);
                animator.SetBool("IsAttacking", true);
                animator.SetBool("IsForward", true);
                animator.SetBool("IsStrong", false);
                animator.SetBool("IsSpecial", true);
                
            }

            if(Input.GetKey(KeyCode.W))
            {
                if (Input.GetKey(KeyCode.P))
                {
                    upBasicAirHitbox.gameObject.SetActive(true); 
                    GetComponent<AnimationEvents>().isAttacking = true;
                    animator.SetBool("IsUp", true);
                    animator.SetBool("IsAirAttacking", true);
                    animator.SetBool("IsForward", false);
                    animator.SetBool("IsStrong", false);
                    animator.SetBool("IsSpecial", false);
                    animator.SetBool("IsJumping", false);
                }
                if (Input.GetKey(KeyCode.I))
                {
                    upSpecialHitbox.gameObject.SetActive(true);
                    GetComponent<AnimationEvents>().isAttacking = true;
                    animator.SetBool("IsJumping", false);
                    animator.SetBool("IsUp", true);
                    animator.SetBool("IsDown", false);
                    animator.SetBool("IsAttacking", true);
                    animator.SetBool("IsForward", false);
                    animator.SetBool("IsStrong", false);
                    animator.SetBool("IsSpecial", true);
                }
                if(Input.GetKey(KeyCode.O))
                {
                    upStrongAirHitbox.gameObject.SetActive(true);
                    GetComponent<AnimationEvents>().isAttacking = true;
                    animator.SetBool("IsUp", true);
                    animator.SetBool("IsDown", false);
                    animator.SetBool("IsAirAttacking", true);
                    animator.SetBool("IsForward", false);
                    animator.SetBool("IsStrong", true);
                    animator.SetBool("IsSpecial", false);
                    animator.SetBool("IsJumping", true); 
                }
               
            }
            if (Input.GetKey(KeyCode.S))
            {
                if (Input.GetKey(KeyCode.P))
                {
                    downBasicAirHitbox.gameObject.SetActive(true);
                    GetComponent<AnimationEvents>().isAttacking = true;
                    animator.SetBool("IsDown", true);
                    animator.SetBool("IsAirAttacking", true);
                    animator.SetBool("IsForward", false);
                    animator.SetBool("IsStrong", false);
                    animator.SetBool("IsSpecial", false);
                    animator.SetBool("IsJumping", true);
                }
                if (Input.GetKey(KeyCode.I))
                {
                    downSpecialHitbox.gameObject.SetActive(true); 
                    animator.SetBool("IsJumping", false);
                    animator.SetBool("IsDown", true);
                    animator.SetBool("IsAttacking", true);
                    animator.SetBool("IsForward", false);
                    animator.SetBool("IsStrong", false);
                    animator.SetBool("IsSpecial", true);
                }
                 if (Input.GetKey(KeyCode.O))
                {
                    downStrongAirHitbox.gameObject.SetActive(true);
                    GetComponent<AnimationEvents>().isAttacking = true;
                    animator.SetBool("IsDown", true);
                    animator.SetBool("IsAirAttacking", true);
                    animator.SetBool("IsForward", false);
                    animator.SetBool("IsStrong", true);
                    animator.SetBool("IsSpecial", false);
                    animator.SetBool("IsJumping", true);
                }
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

        if (Input.GetKey("space") && IsGrounded == true && GetComponent<AnimationEvents>().isAttacking == false)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpHeight);
            animator.SetBool("IsJumping", true); 
        }
        else
        {
            
        }
    }

    public void Attack()
    {
        GetComponent<AnimationEvents>().isAttacking = true;
        animator.SetBool("IsAttacking", true);
        animator.SetBool("IsForward", true);
        animator.SetBool("IsStrong", false);
        animator.SetBool("IsSpecial", false);
        forwarBasicHitbox.gameObject.SetActive(true); 
    }

    public void UpAttack()
    {
        upBasicHitbox.gameObject.SetActive(true);
        GetComponent<AnimationEvents>().isAttacking = true;
        animator.SetBool("IsUp", true); 
        animator.SetBool("IsAttacking", true);
        animator.SetBool("IsForward", false);
        animator.SetBool("IsStrong", false);
        animator.SetBool("IsSpecial", false);//ienumerators don't work but functions work. and ienumeratiors don't work inside functions
    }





}

