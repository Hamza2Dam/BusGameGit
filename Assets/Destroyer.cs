using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) // Colisió Trigger 
    {
       // Debug.Log("Hola");
        if (other.gameObject.CompareTag("car")) // Si l'objecte amb el qual colisionem te un tag == "";
        {
            Destroy(other.gameObject);

        }

        else if (other.gameObject.CompareTag("coin")) // Si l'objecte amb el qual colisionem te un tag == "";
        {
            Destroy(other.gameObject);

        }

        else if (other.gameObject.CompareTag("OilSpeed")) // Si l'objecte amb el qual colisionem te un tag == "";
        {
            Destroy(other.gameObject);

        }


    }
}
