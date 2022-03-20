using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScrollCotxe : MonoBehaviour
{
    public float speed = 15f; // Velocitat del scroll
    private Vector3 StartPosition; // Poscio incial


    public Transform carril1; // Posicio del carril1 on agafarem la x
    public Transform carril2;  
    public Transform carril3;

   

    // each Egg would have a script like this:

    void Start()
    {
        //StartPosition = transform.position; // Posició inicial del objecte (Primer objecte que se spawneja)

    }
    void Awake()
    {
        
        Invoke("SpawnNext", 1f); // Cada x temps (xf) cridarem a la funció SpawnNext per spawnejar un nou objecte
    }
    void SpawnNext()
    {
        float randomNumber = Random.Range(1, 4); // Número random per escollir els carrils on spawnejar l'objecte de manera random
        GameObject Object = Instantiate(gameObject); // Objecte a spawnejar (Instanciar)

        if(randomNumber == 1)  // Si el numero random == 1 spawneja l'objecte al carril1.
        {

            Object.transform.position = new Vector3(carril1.transform.position.x, 40, 0); // Igualem la posicio x del objecte amb la del carril corresponent.
        }
        else if (randomNumber == 2)   
        {
            Object.transform.position = new Vector3(carril2.transform.position.x, 40, 0);

        }

        else if (randomNumber == 3)  
        {
            Object.transform.position = new Vector3(carril3.transform.position.x, 40, 0);

        }

    }


    void Update()
    {
        transform.Translate(translation: Vector3.down * speed *2 * Time.deltaTime); // Scroll del obejcte cap avall amb un speed

        //if (transform.position.y < limitycr1)
        //{

        //    transform.position = StartPosition;
        //}
    }

     
}
