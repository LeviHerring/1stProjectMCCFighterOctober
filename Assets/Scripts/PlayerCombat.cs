using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public bool isAttacking = false;
    bool isDirectionalAttackLocked = false;
    Rigidbody2D rigidBody;
    PlayerController playerController;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P) && isAttacking == false)
        {
            if (GetComponent<PlayerController>().IsGrounded == false)
            {
                StartCoroutine(BasicAirAttack());
            }
            else
            {
                StartCoroutine(BasicAttack());
            }

        }
        else if (Input.GetKey(KeyCode.O) && isAttacking == false)
        {
            if (GetComponent<PlayerController>().IsGrounded == false)
            {
                StartCoroutine(BasicAirStrongAttack());
            }
            else
            {
                StartCoroutine(BasicStrongAttack()); 
            }

        }
        else if (Input.GetKey(KeyCode.I) && isAttacking == false)
        {
            if (GetComponent<PlayerController>().IsGrounded == false)
            {
                animator.SetBool("IsAirAttacking", true);
                animator.SetBool("IsForward", true);
                animator.SetBool("IsStrong", false);
                animator.SetBool("IsSpecial", true);
                animator.SetBool("IsJumping", true);
            }
            else
            {
                isAttacking = true;
                animator.SetBool("IsAttacking", true);
                animator.SetBool("IsForward", true);
                animator.SetBool("IsStrong", false);
                animator.SetBool("IsSpecial", true);

            }
        }

        if (Input.GetKey(KeyCode.W) && isAttacking == false)
        {
            if (Input.GetKey(KeyCode.O))
            {
                isAttacking = true;
                animator.SetBool("IsAttcking", true);
                animator.SetBool("IsUp", true);
                animator.SetBool("IsStrong", true);
                animator.SetBool("IsSpecial", false);
            }
            else if (Input.GetKey(KeyCode.P))
            {
                StartCoroutine(BasicUpAttack());
                Debug.Log("bdfshjbg");
            }
            else if (Input.GetKey(KeyCode.I))
            {
                isAttacking = true;
                animator.SetBool("IsAttacking", true);
                animator.SetBool("IsUp", true);
                animator.SetBool("IsStrong", false);
                animator.SetBool("IsSpecial", true);
            }
            else
            {
                return;
            }
        }
        if (Input.GetKey(KeyCode.S) && isAttacking == false)
        {
            if (Input.GetKey(KeyCode.O))
            {
                isAttacking = true;
                animator.SetBool("IsAttacking", true);
                animator.SetBool("IsDown", true);
                animator.SetBool("IsStrong", true);
                animator.SetBool("IsSpecial", false);
            }
            else if (Input.GetKey(KeyCode.P))
            {
                isAttacking = true;
                animator.SetBool("IsAttacking", true);
                animator.SetBool("IsDown", true);
                animator.SetBool("IsStrong", false);
                animator.SetBool("IsSpecial", false);

            }
            else if (Input.GetKey(KeyCode.I))
            {
                isAttacking = true;
                animator.SetBool("IsAttacking", true);
                animator.SetBool("IsDown", true);
                animator.SetBool("IsStrong", false);
                animator.SetBool("IsSpecial", true);
            }
            else
            {
                return;
            }
        }

        //if (GetComponent<PlayerController>().IsGrounded == false && isAttacking == false)
        //{
        //    if(Input.GetKey(KeyCode.P))
        //    {
        //        isAttacking = true;

        //        animator.SetBool("IsAirAttacking", true);
        //        animator.SetBool("IsForward", true);
        //        animator.SetBool("IsStrong", false);
        //        animator.SetBool("IsSpecial", false);


        //    }
        //    else if (GetComponent<PlayerController>().IsGrounded == true || isAttacking == true)
        //    {
        //        animator.SetBool("IsAirAttacking", false);

        //        isAttacking = false;
        //    }


        //}
    }


    IEnumerator BasicAirAttack()
        {
        isAttacking = true;

        animator.SetBool("IsAirAttacking", true);
        animator.SetBool("IsForward", true);
        animator.SetBool("IsStrong", false);
        animator.SetBool("IsSpecial", false);

        animator.SetBool("IsJumping", true);
        yield return new WaitForSeconds(1f);
        

        animator.SetBool("IsAirAttacking", false);
        animator.SetBool("IsForward", false);
        animator.SetBool("IsStrong", false);
        animator.SetBool("IsSpecial", false);
        animator.SetBool("IsJumping", false); 
        isAttacking = false;
    }


    IEnumerator BasicAttack()
    {
        isAttacking = true;

        animator.SetBool("IsAttacking", true);
        animator.SetBool("IsForward", true);
        animator.SetBool("IsStrong", false);
        animator.SetBool("IsSpecial", false);
        yield return new WaitForSeconds(.2f);
       

        animator.SetBool("IsAttacking", false);
        animator.SetBool("IsForward", false);
        animator.SetBool("IsStrong", false);
        animator.SetBool("IsSpecial", false);
        isAttacking = false;

    }

    IEnumerator BasicUpAttack()
    {
        isAttacking = true;

        animator.SetBool("IsAttacking", true);
        animator.SetBool("IsUp", true);
        animator.SetBool("IsStrong", false);
        animator.SetBool("IsSpecial", false);
        yield return new WaitForSeconds(1f);
        

        animator.SetBool("IsAttacking", false);
        animator.SetBool("IsUp", false);
        animator.SetBool("IsStrong", false);
        animator.SetBool("IsSpecial", false);
        isAttacking = false;


    }
    IEnumerator BasicAirStrongAttack()
    {
        isAttacking = true; 

        animator.SetBool("IsAirAttacking", true);
        animator.SetBool("IsForward", true);
        animator.SetBool("IsStrong", true);
        animator.SetBool("IsSpecial", false);
        animator.SetBool("IsJumping", true);
        yield return new WaitForSeconds(1); 
        animator.SetBool("IsAirAttacking", false);
        animator.SetBool("IsForward", false);
        animator.SetBool("IsStrong", false);
        animator.SetBool("IsSpecial", false);
        animator.SetBool("IsJumping", false); 

        isAttacking = false; 
    }

    IEnumerator BasicStrongAttack()
    {
        isAttacking = true;

        animator.SetBool("IsAttacking", true);
        animator.SetBool("IsForward", true);
        animator.SetBool("IsStrong", true);
        animator.SetBool("IsSpecial", false);
        yield return new WaitForSeconds(.3f);
        animator.SetBool("IsAttacking", false);
        animator.SetBool("IsForward", false);
        animator.SetBool("IsStrong", false);
        animator.SetBool("IsSpecial", false);

        isAttacking = false;
    }

}
