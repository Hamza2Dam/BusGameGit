using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text contador;
    //public Text fin;
    public float tiempo = 0f;


    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo;
       // fin.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        contador.text = " " + tiempo.ToString("f0") + "m";

        //if(tiempo <= 0) 
        //{

        //    contador.text = "0";
        //   // fin.enabled = true;
        //} 
        
    }
}
