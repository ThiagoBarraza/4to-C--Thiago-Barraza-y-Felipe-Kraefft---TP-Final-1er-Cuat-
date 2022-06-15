
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionTest : MonoBehaviour
{
    public int NroVidas;
    public bool Salto = false;
    public PlayerController Play;
    public Text WinLose;
    public Rigidbody rb;
    public bool Playing = true;
    public GameObject panelWin, panelLose;

    public GameObject proye1, proye2;
    
    private GameObject clon1, clon2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(NroVidas <= 0)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            WinLose.text = "Perdiste!!!";
            panelLose.SetActive(true);
            Playing = false;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        Play = FindObjectOfType<PlayerController>();

        if (col.gameObject.tag == "Ground")
        {
            Debug.Log("Grounded");
            Play.hasJump = Play.maxJumps;
        }

        if (col.gameObject.name=="DeathWall")
        {
            transform.position = new Vector3(0, 1, -25);
            NroVidas--;
        }

        if (col.gameObject.name == "WinCoin")
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            WinLose.text = "Ganaste!!!";
            panelWin.SetActive(true);


            for (int i = 0; i < 10; i++)
            {
                clon1 = Instantiate(proye1);
                clon2 = Instantiate(proye2);
            }
            Destroy(clon1, 5);
            Destroy(clon2, 5);
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
