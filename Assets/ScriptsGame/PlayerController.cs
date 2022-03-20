using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject MenuGameOver;
    Rigidbody2D rb; // Rigidbody de l'objecte
    public Transform carril1; // Posicio del carril1 on agafarem la x
    public Transform carril2;
    public Transform carril3;
    public GameObject redcar;
   
    // public int ocupants;
    // public int maxocupants;

    
    ScrollCarreteras scrollspeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.transform.position = new Vector3(0, 0, 0);
        //ocupants = 0;
        //maxocupants = 30;


    }

    // Update is called once per frame
    void Update()
    {
      

    }


   

    public void Right() // Girar a la dreta
    {

         if (rb.transform.position.x == carril2.transform.position.x) // Si l'objecte está en el carril 2 (igualem les coordenades x) el pasem al carril3.x
        {

            rb.transform.position = new Vector3(carril3.transform.position.x, 0, 0);

        }
        else if ( rb.transform.position.x == carril1.transform.position.x) // Si l'objecte está en el carril 1 (igualem les coordenades x) el pasem al carril2.x
        {

            rb.transform.position = new Vector3(carril2.transform.position.x, 0, 0);
            

        }


    }

    public void Left() // Girar a l'esquerra
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

    void OnTriggerEnter2D(Collider2D other) // Colisió Trigger 
    {

        if (other.gameObject.CompareTag("car")) // Si l'objecte amb el qual colisionem te un tag == "";
        {
            
            SceneManager.LoadScene("SampleScene"); // Reiniciem la partida/l'escena
            //Application.Quit();

            //if (GameOver) // Si acaba la partida()
            //{
            //    MenuGameOver.SetActive(true); //activar el menu de GameOver
            //}
            
        }
        else if (other.gameObject.CompareTag("Limits")) // Si l'objecte amb el qual colisionem te un tag == "";
        {
            SceneManager.LoadScene("SampleScene"); // Reiniciem la partida/l'escena
            //Application.Quit();
        }

        else if (other.gameObject.CompareTag("SpawnCotxe")) // Si l'objecte amb el qual colisionem te un tag == "";
        {
            redcar.SetActive(true);
        }

        else if (other.gameObject.CompareTag("OilSpeed")) // Si l'objecte amb el qual colisionem te un tag == "";
        {
            scrollspeed.speed = scrollspeed.speed + 300;
        
            
            

        }

    }



}
