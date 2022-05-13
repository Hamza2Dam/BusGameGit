using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCotxes : MonoBehaviour
{
    public Transform carril1; // Posicio del carril1 on agafarem la x
    public Transform carril2;
    public Transform carril3;


    public GameObject[] car;





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

       InvokeRepeating("SpawnNext", 1f , 1f); // Cada x temps (xf) cridarem a la funció SpawnNext per spawnejar un nou objecte
        

    }
    void SpawnNext()
    {
        int randomcar = Random.Range(0,4);
        float randomNumber = Random.Range(1, 5); // Número random per escollir els carrils on spawnejar l'objecte de manera random
        GameObject generate = Instantiate(car[randomcar]); // Objecte a spawnejar (Instanciar)
    

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
        else if (randomNumber == 4) // 2 cotxes
        {
            float randomNumber2 = Random.Range(1, 4); // Número random per escollir els carrils on spawnejar l'objecte de manera random
            
            if(randomNumber2 == 1) 
            {

                generate.transform.position = new Vector3(carril1.transform.position.x, 40, 0);
             
                GameObject generate2 = Instantiate(car[randomcar]); // Objecte a spawnejar (Instanciar)

                generate2.transform.position = new Vector3(carril2.transform.position.x, 40, 0);

            }
            else if (randomNumber2 == 2)
            {
                generate.transform.position = new Vector3(carril1.transform.position.x, 40, 0);

                GameObject generate2 = Instantiate(car[randomcar]); // Objecte a spawnejar (Instanciar)

                generate2.transform.position = new Vector3(carril3.transform.position.x, 40, 0);

            }
            else if (randomNumber2 == 3)
            {
                generate.transform.position = new Vector3(carril2.transform.position.x, 40, 0);

                GameObject generate2 = Instantiate(car[randomcar]); // Objecte a spawnejar (Instanciar)

                generate2.transform.position = new Vector3(carril3.transform.position.x, 40, 0);

            }


        }
      
        

    }
 
}
