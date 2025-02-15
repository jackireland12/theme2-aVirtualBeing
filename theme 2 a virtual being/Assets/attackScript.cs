using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackScript : MonoBehaviour
{

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        GetComponent<Animator>().speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Example trigger condition

        {
            Debug.Log("eiei");
            //animator.Play("attack"); // Play the "Jump" animation
            heavyAttack();
        }
    }

    void heavyAttack()
    {

        animator.Play("attack",0,0);
    }
}
