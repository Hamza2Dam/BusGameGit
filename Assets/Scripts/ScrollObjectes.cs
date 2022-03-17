using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollObjectes : MonoBehaviour
{
    public float speed = 15f;
    private Vector3 StartPosition;
    private int limitycr1 = -5;

    public Transform carril1;
    public Transform carril2;
    public Transform carril3;

    // each Egg would have a script like this:

    void Start()
    {
        StartPosition = transform.position;

    }
    void Awake()
    {
    
        Invoke("SpawnNext", 1f);
    }
    void SpawnNext()
    {
        float randomNumber = Random.Range(1, 3);
        GameObject FallingEggs = Instantiate(gameObject);

        if(randomNumber == 1) 
        {

            FallingEggs.transform.position = new Vector3(carril1.transform.position.x, 14, 0);
        }
        else if (randomNumber == 2) 
        {
            FallingEggs.transform.position = new Vector3(carril2.transform.position.x, 14, 0);

        }

        else if (randomNumber == 3)
        {
            FallingEggs.transform.position = new Vector3(carril3.transform.position.x, 14, 0);

        }

    }


    void Update()
    {
        transform.Translate(translation: Vector3.down * speed *2 * Time.deltaTime);

        //if (transform.position.y < limitycr1)
        //{

        //    transform.position = StartPosition;
        //}
    }

     
}
