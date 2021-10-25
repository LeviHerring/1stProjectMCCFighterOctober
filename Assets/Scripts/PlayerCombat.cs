using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public bool isAttacking = false;
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
        if (GetComponent<PlayerController>().IsGrounded == false && isAttacking == false)
        {
            if(Input.GetKey(KeyCode.P))
            {
                isAttacking = true;
                animator.SetBool("IsAirAttacking", true);
            }
            else if (GetComponent<PlayerController>().IsGrounded == true || isAttacking == true)
            {
                animator.SetBool("IsAirAttacking", false);
                isAttacking = false;
            }
 
           
        }
    }


}
