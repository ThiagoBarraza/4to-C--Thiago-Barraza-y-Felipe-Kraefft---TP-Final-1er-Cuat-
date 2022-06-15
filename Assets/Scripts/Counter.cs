using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text Contador;
    float time;
    public CollisionTest Colision;
    public ButtonScript btnScript;
    int cont;

    // Start is called before the first frame update
    void Start()
    {
        Colision = FindObjectOfType<CollisionTest>();
        btnScript = FindObjectOfType<ButtonScript>();

        time = 0;
        cont = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Colision.Playing) {
            
            time += Time.deltaTime;
            
            Contador.text = "Contador: " + (Mathf.Floor(time * 10)/10).ToString();
            cont++;
        }
        else if (!Colision.Playing && cont == 1)
        {
            Contador.text = "Tu tiempo es " + time.ToString();

            cont--;
        }
        else
        {
            time = 0;
        }
    }
}
