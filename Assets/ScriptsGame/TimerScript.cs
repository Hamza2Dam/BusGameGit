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

    

 


    public GameObject[] speed;


    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo; // Mostrem la variable tiempo al textUI del joc.
                                      // fin.enabled = false;


        // Velocitats Inicials del scroll de cada objecte
        speed[0].GetComponent<ScrollCotxe>().speed = 6; // Coche vermell
        speed[1].GetComponent<ScrollCotxe>().speed = 6; // Coche blau
        speed[2].GetComponent<ScrollCotxe>().speed = 5; // Coin
        speed[3].GetComponent<ScrollCotxe>().speed = 5; // Oil


        

        


    }

    // Update is called once per frame
    void Update()
    {
        tempsirecorregut();


       






    }

    public void tempsirecorregut()
    {

        tiempo += Time.deltaTime; // Cada segon el temps augmentará 1


        int x = 0;

        for (x=0;x<speed.Length;x++) // Recorregut per tots els objectes
        {
            // Sumem la velocitat segons passa el temps al scrollspeed de tots els objectes
            speed[x].GetComponent<ScrollCotxe>().speed += Time.deltaTime / 20;
            Debug.Log(speed[x].GetComponent<ScrollCotxe>().speed);

        }


        

        contador.text = " " + tiempo.ToString("f0") + "m"; // Mostrem els temps/metres actualitzat cada segon


        puntuacio.text = "Score : " + contador.text; // Mostrem la puntuacio al final

    }

    

   
}
