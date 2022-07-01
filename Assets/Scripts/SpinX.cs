using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinX : MonoBehaviour
{
    Vector3 v3 = Vector3.zero;
    public float speed = 25.0f;
    public float Yrotation = 0f;
    public float Zrotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = v3;
    }

    // Update is called once per frame
    void Update()
    {
        v3.x += speed * Time.deltaTime;
        v3.y = Yrotation;
        v3.z = Zrotation;
        transform.eulerAngles = v3;
    }
}
