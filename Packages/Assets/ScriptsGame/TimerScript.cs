using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text contador;
    //public Text fin;
    public float tiempo = 0f; // Començem el temps a 0


    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo; // Mostrem la variable tiempo al textUI del joc.
       // fin.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime; // Cada segon el temps augmentará 1
        contador.text = " " + tiempo.ToString("f0") + "m"; // Mostrem els temps/metres actualitzat cada segon

        //if(tiempo <= 0) 
        //{

        //    contador.text = "0";
        //   // fin.enabled = true;
        //} 
        
    }
}
