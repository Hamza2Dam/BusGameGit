using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCarreteras : MonoBehaviour

{

    private int limitmapa = 23;
    public int scrollspeed;
   
    

    // Start is called before the first frame update
    void Start()
    {

       

    }   

    // Update is called once per frame
     void Update()
     {

        Scroll(5);

     } 


    public void Scroll(int scrollspeed) 
    {
        
 

        transform.position += new Vector3(0, -scrollspeed * Time.deltaTime);

        if (transform.position.y < -limitmapa)
        {
            transform.position = new Vector3(0, limitmapa);
        }


    }



}
