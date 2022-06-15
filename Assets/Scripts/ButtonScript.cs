using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    CollisionTest Colision;
    public GameObject panelWin, panelLose, btn_PlayAgain, Player;
    public Text Win_Lose;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Colision = FindObjectOfType<CollisionTest>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Colision.Playing)
        {
            Win_Lose.enabled = true;
            btn_PlayAgain.SetActive(true);
        }

        if (Colision.Playing)
        {
            panelLose.SetActive(false);
            panelWin.SetActive(false);
            Win_Lose.enabled = false;
            btn_PlayAgain.SetActive(false);
        }
    }

    public void PlayAgain(){
        rb.constraints = RigidbodyConstraints.None;
        rb.constraints = RigidbodyConstraints.FreezeRotation;

        Player.transform.position = new Vector3(0, 1, -25);
        Player.transform.eulerAngles = new Vector3(0, 0, 0);
        Colision.Playing = true;
        Colision.vidas = Colision.NroVidas;
    }
}
