using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScrollCotxe : MonoBehaviour
{
    public float speed = 15f; // Velocitat del scroll
    private Vector3 StartPosition; // Poscio incial






    // each Egg would have a script like this:

    void Start()
    {
        //StartPosition = transform.position; // Posició inicial del objecte (Primer objecte que se spawneja)

    }



    void Update()
    {
        transform.Translate(translation: Vector3.down * speed * 2 * Time.deltaTime); // Scroll del obejcte cap avall amb un speed

        //if (transform.position.y < limitycr1)
        //{

        //    transform.position = StartPosition;
        //}
    }

    void OnTriggerEnter2D(Collider2D other) // Colisió Trigger 
    {

        if (other.gameObject.CompareTag("Destroyer")) // Si l'objecte amb el qual colisionem te un tag == "";
        {
            Destroy(this.gameObject);
        }


    }
}
