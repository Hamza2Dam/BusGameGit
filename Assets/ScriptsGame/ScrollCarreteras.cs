using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCarreteras : MonoBehaviour

{
    private  float speed = 5f; // Velocitat del scroll
    private Vector3 StartPosition; // Posició inicial 
    private double limitycr1 = -1; // Limit del fons (y) vertical




    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position; // Posició Inicial


    }   

    // Update is called once per frame
     void Update()
    {

        //Scroll(speed);

        //transform.Translate(translation: Vector3.down*speed*Time.deltaTime); // Scroll avall amb una velocitat

        //if (transform.position.y < limitycr1) // Quan arribi a el seu limit torna a la posició inicial així fa el efecte infinit
        //{

        //    transform.position = StartPosition; // Tornar a la posició inicial


        //}

        transform.position += new Vector3(0, -5 * Time.deltaTime);

        if (transform.position.y < -23)
        {
            transform.position = new Vector3(0, 23f);
        }

        //if(TimerScript)
    }


 
}
