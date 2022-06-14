using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float ZSpeed;
    public float XSpeed;
    public float RSpeed;
    public float Jump;

    public int maxJumps;
    public float JumpForce;

    int hasJump;

    Rigidbody rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hasJump = maxJumps;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, ZSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -ZSpeed * .5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(XSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-XSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, RSpeed, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -RSpeed, 0);
        }

        if (Input.GetKey(KeyCode.Space) && hasJump > 0)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            hasJump--;
        }

        if (Input.GetKey("left shift"))
        {
            transform.Translate(0, -Jump, 0);
        }

        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "Ground")
            {
                hasJump = maxJumps;
            }
        }
    }
}
