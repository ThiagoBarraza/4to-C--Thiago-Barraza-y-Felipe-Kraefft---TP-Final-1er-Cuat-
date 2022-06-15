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
    public CollisionTest ColT;
    public GameObject cam1erP, cam3erP;

    public int hasJump;

    Rigidbody rb;
    private bool cam1erP_isActive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ColT = FindObjectOfType<CollisionTest>();
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
            hasJump --;
        }

        if(Input.GetKey(KeyCode.Space) && ColT.Playing == false)
        {
            transform.Translate(0, Jump, 0);
        }

        if (Input.GetKey("left shift") && ColT.Playing == false)
        {
            transform.Translate(0, -Jump, 0);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (cam1erP_isActive)
            {
                cam1erP.SetActive(false);
                cam3erP.SetActive(true);

                cam1erP_isActive = false;
            }
            else if (!cam1erP_isActive)
            {
                cam1erP.SetActive(true);
                cam3erP.SetActive(false);

                cam1erP_isActive = true;
            }

        }

    }
}
