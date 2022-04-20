using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCotxes : MonoBehaviour
{
    public Transform carril1; // Posicio del carril1 on agafarem la x
    public Transform carril2;
    public Transform carril3;

    public GameObject car;



    // Start is called before the first frame update


    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
     
    }

    void Awake()
    {

       InvokeRepeating("SpawnNext", 1f , 1f); // Cada x temps (xf) cridarem a la funci� SpawnNext per spawnejar un nou objecte
        

    }
    void SpawnNext()
    {
        float randomNumber = Random.Range(1, 4); // N�mero random per escollir els carrils on spawnejar l'objecte de manera random
        GameObject generate = Instantiate(car); // Objecte a spawnejar (Instanciar)

        if (randomNumber == 1)  // Si el numero random == 1 spawneja l'objecte al carril1.
        {

            generate.transform.position = new Vector3(carril1.transform.position.x, 40, 0); // Igualem la posicio x del objecte amb la del carril corresponent.
        }
        else if (randomNumber == 2)
        {
            generate.transform.position = new Vector3(carril2.transform.position.x, 40, 0);

        }

        else if (randomNumber == 3)
        {
            generate.transform.position = new Vector3(carril3.transform.position.x, 40, 0);

        }

    }
}