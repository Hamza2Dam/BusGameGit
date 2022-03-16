using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    private float limitesq = -1.5f;
    private float limitdreta = 1.5f;
    private float marge = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
    

        if (Input.GetKey(KeyCode.A)) 
        {

            // rb.AddForce(Vector2.left);
           rb.transform.position = new Vector3(limitesq, -1, 0);

        }


        if (Input.GetKey(KeyCode.D))
        {

            // rb.AddForce(Vector2.right);
            rb.transform.position = new Vector3(limitesq + marge , -1, 0);

        }

      




    }
}
