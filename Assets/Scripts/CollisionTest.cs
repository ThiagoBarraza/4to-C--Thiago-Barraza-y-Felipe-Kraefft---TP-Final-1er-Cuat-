using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionTest : MonoBehaviour
{
    int i;
    public int NroVidas;
    public bool Salto = false;
    public PlayerController Play;
    public Text WinLose;
    public Rigidbody rb;
    public bool Playing = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(i >= NroVidas)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            WinLose.text = "Perdiste!!!";
            Playing = false;
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
            rb.constraints = RigidbodyConstraints.FreezeAll;
            WinLose.text = "Ganaste!!!";
            Playing = false;
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
