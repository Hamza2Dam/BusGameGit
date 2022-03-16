using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObjectes : MonoBehaviour
{
    public float speed = 6f;
    private Vector3 StartPosition;
    private int limitycr1 = -5;

    // each Egg would have a script like this:

    void Start()
    {
        StartPosition = transform.position;

    }
    void Awake()
    {
    
        Invoke("SpawnNext", 2f);
    }
    void SpawnNext()
    {
        float randomNumber = Random.Range(-2, 2);
        GameObject FallingEggs = Instantiate(gameObject);
        FallingEggs.transform.position = new Vector3(randomNumber, 4, 0);
    }


    void Update()
    {
        transform.Translate(translation: Vector3.down * speed * Time.deltaTime);

        //if (transform.position.y < limitycr1)
        //{

        //    transform.position = StartPosition;
        //}
    }
}
