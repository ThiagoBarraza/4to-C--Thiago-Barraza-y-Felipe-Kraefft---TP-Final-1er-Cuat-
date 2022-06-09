using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    int i;
    public int NroVidas;
    public bool Salto = false;
    public PlayerController Play;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(i >= NroVidas)
        {
            transform.position = new Vector3(925, 465, 0);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        Play = FindObjectOfType<PlayerController>();

        Play.num = 0;

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
        
        Salto = false;
    }

    void OnCollisionStay()
    {
        Salto = true;
    }
}
