using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGasoil : MonoBehaviour
{
    public Transform carril1; // Posicio del carril1 on agafarem la x
    public Transform carril2;
    public Transform carril3;

    public GameObject gasoil;

    





    private Vector3 StartPosition; // Poscio incial



    // Start is called before the first frame update


    void Start()
    {

    }

    void Update()
    {
        // car.transform.Translate(translation: Vector3.down * speed * 2 * Time.deltaTime); // Scroll del obejcte cap avall amb un speed
    }
    // Update is called once per frame


    void Awake()
    {

        InvokeRepeating("SpawnNext", 1f, 5f); // Cada x temps (xf) cridarem a la funció SpawnNext per spawnejar un nou objecte


    }
    void SpawnNext()
    {
        float randomNumbercarril = Random.Range(1, 4); // Número random per escollir els carrils on spawnejar l'objecte de manera random
        GameObject generate = Instantiate(gasoil); // Objecte a spawnejar (Instanciar)

        if (randomNumbercarril == 1)  // Si el numero random == 1 spawneja l'objecte al carril1.
        {



            generate.transform.position = new Vector3(carril1.transform.position.x, 43, 0); // Igualem la posicio x del objecte amb la del carril corresponent.



        }
        else if (randomNumbercarril == 2) // Carril2
        {



            generate.transform.position = new Vector3(carril2.transform.position.x, 43, 0); // Igualem la posicio x del objecte amb la del carril corresponent.



        }

        else if (randomNumbercarril == 3) // Carril3
        {




            generate.transform.position = new Vector3(carril3.transform.position.x, 43, 0); // Igualem la posicio x del objecte amb la del carril corresponent.


        }

    }

 
}
