using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCarreteras : MonoBehaviour

{

    private int limitmapa = 23;



    public GameObject map1;
    public GameObject map2;
    public float scrollspeed;

    

    // Start is called before the first frame update
    void Start()
    {
        scrollspeed = 3;


    }   

    // Update is called once per frame
     void Update()
     {

        Scroll();

     } 


    public void Scroll() 
    {

         



        map1.transform.position += new Vector3(0, -scrollspeed * Time.deltaTime);

        if (map1.transform.position.y < -limitmapa)
        {
            map1.transform.position = new Vector3(0, limitmapa);
        }

        map2.transform.position += new Vector3(0, -scrollspeed * Time.deltaTime);

        if (map2.transform.position.y < -limitmapa)
        {
            map2.transform.position = new Vector3(0, limitmapa);
        }


    }



}
