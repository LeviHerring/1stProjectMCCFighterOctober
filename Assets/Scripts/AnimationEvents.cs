using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    public bool isAttacking; 
    public Animator animator;
   PlayerController playerController; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnAnimationEnd()
    {
        animator.SetBool("IsAttacking", false);
        animator.SetBool("IsForward", false);
        animator.SetBool("IsStrong", false);
        animator.SetBool("IsSpecial", false);
        animator.SetBool("IsUp", false);
        animator.SetBool("IsDown", false);
        animator.SetBool("IsAirAttacking", false);

        isAttacking = false; 
    }

    void OnAnimationEndInAir()
    {
        animator.SetBool("IsJumping", false);
        animator.SetBool("IsAttacking", false);
        animator.SetBool("IsForward", false);
        animator.SetBool("IsStrong", false);
        animator.SetBool("IsSpecial", false);
        animator.SetBool("IsUp", false);
        animator.SetBool("IsDown", false);
        animator.SetBool("IsAirAttacking", false);

        isAttacking = false;
    }
}
