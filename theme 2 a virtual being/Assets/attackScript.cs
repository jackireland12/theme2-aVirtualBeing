using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackScript : MonoBehaviour
{

    private Animator animator;
    private float attackDuration = 1f; // Adjust based on your animation length
    private bool isAttacking = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //GetComponent<Animator>().speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isAttacking) // Example trigger condition

        {
            Debug.Log("eiei");
            //animator.Play("attack"); // Play the "Jump" animation
            heavyAttack();
        }
    }

    void heavyAttack()
    {
        
        animator.SetTrigger("attackTrigger");
        isAttacking = true;
        StartCoroutine(ResetAttackState());
    }
    IEnumerator ResetAttackState()
    {
        yield return new WaitForSeconds(attackDuration);
        isAttacking = false;
        // If you need to reset any parameters in the Animator:
        // animator.ResetTrigger("attack");
    }
}
