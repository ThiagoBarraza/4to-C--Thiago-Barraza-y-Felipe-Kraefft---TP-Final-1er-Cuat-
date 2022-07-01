using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObsY : MonoBehaviour
{
    public Vector3 PosInicial;
    public Vector3 PosFinal;

    public float velocidad;
    bool if1 = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (gameObject.transform.position.y >= PosFinal.y && !if1)
        {
            gameObject.transform.Translate(0 , -velocidad, 0);
        }
        else
        {
            if1 = true;
        }
        if (gameObject.transform.position.y != PosInicial.y && if1)
        {
            gameObject.transform.Translate(0, velocidad, 0);
        }
        else
        {
            if1 = false;
        }
    }
}
