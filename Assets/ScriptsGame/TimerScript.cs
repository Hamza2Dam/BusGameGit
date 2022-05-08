using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text contador;
    //public Text fin;
    public float tiempo = 0f; // Començem el temps a 0
    public Text puntuacio;

    public ScrollCarreteras speedroads;

    public ScrollCotxe speedcar;
    public ScrollCotxe speedcar2;
    public ScrollCotxe speedcar3;


    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo; // Mostrem la variable tiempo al textUI del joc.
       // fin.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        tempsirecorregut();
        Debug.Log(speedcar.speed);
        Debug.Log(speedcar2.speed);
        Debug.Log(speedcar3.speed);
       
      
        
    }

    public void tempsirecorregut()
    {

        tiempo += Time.deltaTime; // Cada segon el temps augmentará 1

        speedroads.scrollspeed += Time.deltaTime / 10; // la velocitat anirá aumentant
       
        speedcar.speed += Time.deltaTime / 10; // la velocitat anirá aumentant
        speedcar2.speed += Time.deltaTime / 10; // la velocitat anirá aumentant
        speedcar3.speed += Time.deltaTime / 10; // la velocitat anirá aumentant


        

        contador.text = " " + tiempo.ToString("f0") + "m"; // Mostrem els temps/metres actualitzat cada segon


        puntuacio.text = "Score : " + contador.text; // Mostrem la puntuacio al final

    }

    

   
}
