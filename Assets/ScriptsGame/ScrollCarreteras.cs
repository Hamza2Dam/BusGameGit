using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCarreteras : MonoBehaviour

{
    public  float speed = 6f; // Velocitat del scroll
    private Vector3 StartPosition; // Posició inicial 
    private int limitycr1 = -30; // Limit del fons (y) vertical


    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position; // Posició Inicial

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector3.down*speed*Time.deltaTime); // Scroll avall amb una velocitat

        //if(transform.position.y < limitycr1) // Quan arribi a el seu limit torna a la posició inicial així fa el efecte infinit
        //{

        //    transform.position = StartPosition; // Tornar a la posició inicial
        //}


        //if(TimerScript)
    }
}
