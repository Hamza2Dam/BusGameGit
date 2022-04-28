using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public Transform carril1; // Posicio del carril1 on agafarem la x
    public Transform carril2;
    public Transform carril3;

    public GameObject coin;





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
        
   
    


        if (randomNumbercarril == 1)  // Si el numero random == 1 spawneja l'objecte al carril1.
        {
            int randomcoins = Random.Range(1, 6); // Numero de monedes Random
            float carril1pos = carril1.transform.position.x; // Posicio x del carril
            Groupofcoins(carril1pos, randomcoins); // Cridem a la funcio spawncoins li enviem la posicio x del carril i el numero de monedes que volem
          
        

        }
        else if (randomNumbercarril == 2) // Carril2
        {
            
            int randomcoins = Random.Range(1, 6);
            float carril2pos = carril2.transform.position.x;
            Groupofcoins(carril2pos, randomcoins );


        }

        else if (randomNumbercarril == 3) // Carril3
        {
          
            int randomcoins = Random.Range(1, 6);
            float carril3pos = carril3.transform.position.x;
            Groupofcoins(carril3pos , randomcoins);


        }

    }


    public void Groupofcoins(float carril, int coins)
    {

       
        int y = 40; // La posicio y de la moneda
      

     

        for (int x = 0; x < coins; x++) // Bucle per spawnejar monedes
        {
         
            GameObject generate = Instantiate(coin); // Objecte a spawnejar (Instanciar)
            generate.transform.position = new Vector3(carril, y, 0); // Colocar l'objecte al carril que ens interesa i a la y que ens interesa
           
            y++; // Sumem +1 a la posicio y de la moneda perque no es spawneji a sobre de la anterior


        }

    }

}

