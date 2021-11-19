using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    public bool isAttacking; 
    public Animator animator;
   PlayerController playerController;

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

    void HitBoxClose()
    {
        forwarBasicHitbox.gameObject.SetActive(false);
        downBasicHitbox.gameObject.SetActive(false);
        upBasicHitbox.gameObject.SetActive(false);
        forwardStrongHitbox.gameObject.SetActive(false);
        downStrongHitbox.gameObject.SetActive(false);
        upStrongHitbox.gameObject.SetActive(false);
        forwardSpecialHitbox.gameObject.SetActive(false);
        downSpecialHitbox.gameObject.SetActive(false);
        upSpecialHitbox.gameObject.SetActive(false);
        forwardBasicAirHitbox.gameObject.SetActive(false);
        downBasicAirHitbox.gameObject.SetActive(false);
        upBasicAirHitbox.gameObject.SetActive(false);
        forwardStrongAirHitbox.gameObject.SetActive(false);
        downStrongAirHitbox.gameObject.SetActive(false);
        upStrongAirHitbox.gameObject.SetActive(false);
    }
}
