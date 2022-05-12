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

    public ScrollCarreteras velocitatmapa;
    public GameObject[] velocitatobjectes;



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

        Debug.Log("Coche vermell" + velocitatobjectes[0].GetComponent<ScrollCotxe>().speed);
        Debug.Log("Coche blau " + velocitatobjectes[1].GetComponent<ScrollCotxe>().speed);
        Debug.Log(" Coins " + velocitatobjectes[2].GetComponent<ScrollCotxe>().speed);
        Debug.Log("Oil " + velocitatobjectes[3].GetComponent<ScrollCotxe>().speed);



        






    }

    public void tempsirecorregut()
    {

        tiempo += Time.deltaTime; // Cada segon el temps augmentará 1


        int x = 0;
   

        for (x = 0; x < velocitatobjectes.Length; x++) // Recorregut per tots els objectes
        {
            //Sumem la velocitat segons passa el temps al scrollspeed de tots els objectes

            velocitatmapa.scrollspeed += Time.deltaTime / 100;

            // La velocitat de cada objecte dependrá de la del mapa
            velocitatobjectes[x].GetComponent<ScrollCotxe>().speed = velocitatmapa.scrollspeed ;
           
            Debug.Log("Velocitat mapa " + velocitatmapa.scrollspeed);

        }

       




        contador.text = " " + tiempo.ToString("f0") + "m"; // Mostrem els temps/metres actualitzat cada segon


        puntuacio.text = "Score : " + contador.text; // Mostrem la puntuacio al final

    }

    

   
}
