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
    public ScrollCotxe speedoil;
    public ScrollCotxe speedcoin;


    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo; // Mostrem la variable tiempo al textUI del joc.
                                      // fin.enabled = false;


        speedcar.speed = 6; // Velocitat inicial Car
        speedoil.speed = 3; // Velocitat inicial Oil
        speedcoin.speed = 1; // Velocitat inicial Coin

    }

    // Update is called once per frame
    void Update()
    {
        tempsirecorregut();
        Debug.Log(speedcar.speed);
        Debug.Log(speedoil.speed);
        Debug.Log(speedcoin.speed);
       
      
        
    }

    public void tempsirecorregut()
    {

        tiempo += Time.deltaTime; // Cada segon el temps augmentará 1

        speedroads.scrollspeed += Time.deltaTime / 10; // la velocitat anirá aumentant
       
        speedcar.speed += Time.deltaTime / 15; // la velocitat anirá aumentant
        speedoil.speed += Time.deltaTime / 15; // la velocitat anirá aumentant
        speedcoin.speed += Time.deltaTime / 15; // la velocitat anirá aumentant


        

        contador.text = " " + tiempo.ToString("f0") + "m"; // Mostrem els temps/metres actualitzat cada segon


        puntuacio.text = "Score : " + contador.text; // Mostrem la puntuacio al final

    }

    

   
}
