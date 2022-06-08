using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    int i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(i == 3)
        {
            transform.position = new Vector3(925, 465, 0);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        
        
        if (col.gameObject.name=="DeathWall")
        {
            transform.position = new Vector3(0, 1, -25);
            i++;
        }

        if (col.gameObject.name == "WinCoin")
        {
            transform.position = new Vector3(925, 425, 20);
        }

    }

    void OnCollisionExit()
    {

    }

    void OnCollisionStay()
    {

    }
}
