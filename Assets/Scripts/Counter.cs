using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text Contador;
    float time;
    public CollisionTest Colision;

    // Start is called before the first frame update
    void Start()
    {
        Colision = FindObjectOfType<CollisionTest>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Colision.Playing) {
            time = Time.time * 10;
            time = Mathf.Floor(time) / 10;

            Contador.text = "Contador: " + time.ToString();
        }
        else
        {
            Contador.text = "Tu tiempo es " + time.ToString();
        }
    }
}
