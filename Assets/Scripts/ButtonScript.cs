using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public CollisionTest Colision;
    public Button PlayAgain;
    public GameObject panelWin, panelLose;
    public Text Win_Lose;

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
            PlayAgain.enabled = true;
        }

        if (Colision.Playing)
        {
            PlayAgain.enabled = false;
            panelLose.SetActive(false);
            panelWin.SetActive(false);
            Win_Lose.enabled = false;
        }
    }
}
