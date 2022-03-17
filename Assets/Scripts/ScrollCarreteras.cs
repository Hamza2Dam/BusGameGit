using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCarreteras : MonoBehaviour

{
    public float speed = 6f;
    private Vector3 StartPosition;
    private int limitycr1 = -5;


    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector3.down*speed*Time.deltaTime);

        if(transform.position.y < limitycr1) 
        {

            transform.position = StartPosition;
        }


        //if(TimerScript)
    }
}
