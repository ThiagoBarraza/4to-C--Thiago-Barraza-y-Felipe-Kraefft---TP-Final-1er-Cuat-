﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObs : MonoBehaviour
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
        Vector3 Neg = new Vector3(-6.4f, 0.7f, 5);
        Vector3 Pos = new Vector3(6.4f, 0.7f, 5);

        if (gameObject.transform.position!=PosFinal && if1 == false)
        {
            gameObject.transform.Translate(velocidad, 0, 0);
        }
        else {
            if1 = true;
        }
        if(gameObject.transform.position != PosInicial && if1 == true)
        {
            gameObject.transform.Translate(-velocidad, 0, 0);
        }
        else
        {
            if1 = false;
        }
    }
}
