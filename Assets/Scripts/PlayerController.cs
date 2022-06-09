using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MSpeed;
    public float RSpeed;
    public CollisionTest Test;
    float i;
    public int num;
    
    
    // Start is called before the first frame update
    void Start()
    {
        i = 2 / MSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Test = FindObjectOfType<CollisionTest>();
        
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
        if (Input.GetKey(KeyCode.Space) && num != i)
        {
            num++;
            transform.Translate(0, MSpeed, 0);
        }
    }
}
