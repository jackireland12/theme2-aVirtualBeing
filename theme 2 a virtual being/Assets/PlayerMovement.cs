using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public float speed;
    private Rigidbody2D rb;
    Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(0.15f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            rb.MovePosition(rb.position - velocity);
        }
        if (Input.GetKey("d"))
        {
            rb.MovePosition(rb.position + velocity);
        }
    }
}
