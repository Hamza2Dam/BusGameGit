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

        InvokeRepeating("SpawnNext", 1f, 8f); // Cada x temps (xf) cridarem a la funció SpawnNext per spawnejar un nou objecte


    }
    void SpawnNext()
    {
        float randomNumbercarril = Random.Range(1, 4); // Número random per escollir els carrils on spawnejar l'objecte de manera random
        
   
    


        if (randomNumbercarril == 1)  // Si el numero random == 1 spawneja l'objecte al carril1.
        {
            int randomcoins = Random.Range(1, 6);
            float carril1pos = carril1.transform.position.x;
            Groupofcoins(carril1pos, randomcoins);
            //generate.transform.position = new Vector3(carril1.transform.position.x, 40, 0); // Igualem la posicio x del objecte amb la del carril corresponent.
        

        }
        else if (randomNumbercarril == 2)
        {
            // generate.transform.position = new Vector3(carril2.transform.position.x, 40, 0);
            int randomcoins = Random.Range(1, 6);
            float carril2pos = carril2.transform.position.x;
            Groupofcoins(carril2pos, randomcoins );


        }

        else if (randomNumbercarril == 3)
        {
            // generate.transform.position = new Vector3(carril3.transform.position.x, 40, 0);
            int randomcoins = Random.Range(1, 6);
            float carril3pos = carril3.transform.position.x;
            Groupofcoins(carril3pos , randomcoins);


        }

    }


    public void Groupofcoins(float carril, int coins)
    {

       
        int y = 40;
        Debug.Log(coins);

     

        for (int x = 0; x < coins; x++)
        {
            Debug.Log("SPAWNING");
            GameObject generate = Instantiate(coin); // Objecte a spawnejar (Instanciar)
            generate.transform.position = new Vector3(carril, y, 0);
           
            y++;


        }

    }

}

