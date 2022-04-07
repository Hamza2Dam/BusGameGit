using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCarreteras : MonoBehaviour

{
    public int scrollspeed;
    private int limitmapa = 23;

    

    // Start is called before the first frame update
    void Start()
    {

        scrollspeed = 5;

    }   

    // Update is called once per frame
     void Update()
     {

        transform.position += new Vector3(0, -scrollspeed * Time.deltaTime);

        if (transform.position.y < -limitmapa)
        {
            transform.position = new Vector3(0, limitmapa);
        }


     }


 
}
