using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MSpeed;
    public float RSpeed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, MSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -MSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, RSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -RSpeed, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, MSpeed, 0);
        }
    }
}
