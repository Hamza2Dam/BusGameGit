using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    public Transform carril1;
    public Transform carril2;
    public Transform carril3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.transform.position = new Vector3(0, 0, 0);


    }

    // Update is called once per frame
    void Update()
    {
      

    }


   

    public void Right() 
    {

         if (rb.transform.position.x == carril2.transform.position.x)
        {

            rb.transform.position = new Vector3(carril3.transform.position.x, 0, 0);

        }
        else if ( rb.transform.position.x == carril1.transform.position.x)
        {

            rb.transform.position = new Vector3(carril2.transform.position.x, 0, 0);

        }


    }

    public void Left()
    {
        if ( rb.transform.position.x == carril2.transform.position.x)
        {

            // rb.AddForce(Vector2.left);
            //rb.transform.position = new Vector3(limitesq, -1, 0);

            rb.transform.position = new Vector3(carril1.transform.position.x, 0, 0);


        }
        else if ( rb.transform.position.x == carril3.transform.position.x)
        {

            rb.transform.position = new Vector3(carril2.transform.position.x, 0, 0);

        }



    }



}
