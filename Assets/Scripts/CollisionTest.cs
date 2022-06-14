
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

    public GameObject proye1, proye2;

    private GameObject clon1, clon2;

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
            
            for(int i = 0; i < 10; i++)
            {
                clon1 = Instantiate(proye1);
                clon2 = Instantiate(proye2);
            }

            Wait(5);
            Destroy(clon1);
            Destroy(clon2);
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

    IEnumerable Wait(int sec)
    {
        yield return new WaitForSeconds(sec);
    }
}
