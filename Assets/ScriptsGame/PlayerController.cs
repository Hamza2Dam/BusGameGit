using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb; // Rigidbody de l'objecte
    public Transform carril1; // Posicio del carril1 on agafarem la x
    public Transform carril2;
    public Transform carril3;
    public GameObject redcar;
    public GameObject GameOverObject;
    public GameObject SpawnCotxes;
    public GameObject SpawnMonedes;
    public GameObject timer;

    public AudioSource coinssound;
    public AudioSource gameoversound;
    public AudioSource gasoilsound;
    public AudioSource sonidojuego;

    public GasolinaBar gasolinascript;
    public GameOver gameOverscript;




    //public int maxbar = 100;




    private int contadorcoins;
    private bool stopGame;

    private Vector2 startTouchPosition;
    private Vector2 currentPosition;
    private Vector2 endTouchPosition;
    private bool stopTouch = false;

    public float swipeRange;
    public float tapRange;

    public  Text coins;
    public Text finalcoins;

   public ScrollCarreteras speed;
    
    
    







    // public int ocupants;
    // public int maxocupants;


    //ScrollCarreteras scrollspeed;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.transform.position = new Vector3(0, 0, 0);
        //ocupants = 0;
        //maxocupants = 30;

        // speed = GetComponent<ScrollCarreteras>();

        rb.transform.position = new Vector3(carril2.transform.position.x, carril2.transform.position.y, 0);
        contadorcoins = 0;
        stopGame = false;
        Time.timeScale = 1;


    }

    // Update is called once per frame
    void Update()
    {

        Swipe();
        movementpc();
       
       

    }


    // Android Movement

    public void Swipe()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            currentPosition = Input.GetTouch(0).position;
            Vector2 Distance = currentPosition - startTouchPosition;

            if (!stopTouch)
            {

                if (Distance.x < -swipeRange)
                {
                    Left();


                    stopTouch = true;
                }
                else if (Distance.x > swipeRange)
                {
                    Right();


                    stopTouch = true;
                }


            }

        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;

            endTouchPosition = Input.GetTouch(0).position;

            Vector2 Distance = endTouchPosition - startTouchPosition;

            if (Mathf.Abs(Distance.x) < tapRange && Mathf.Abs(Distance.y) < tapRange)
            {
                //outputText.text = "Tap";
            }

        }


    }



    // Pc Movement


    private void movementpc() 
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Left();
        }
        else if (Input.GetKeyDown(KeyCode.D)) 
        {

            Right();
        }



    }







  


    private  void Right() // Girar a la dreta
    {

        if (rb.transform.position == carril2.transform.position) // Si l'objecte est� en el carril 2 (igualem les coordenades x) el pasem al carril3.x
        {

            rb.transform.position = new Vector3(carril3.transform.position.x, carril3.transform.position.y, 0);

         

        }
        else if (rb.transform.position == carril1.transform.position) // Si l'objecte est� en el carril 1 (igualem les coordenades x) el pasem al carril2.x
        {

            rb.transform.position = new Vector3(carril2.transform.position.x, carril2.transform.position.y, 0);


        }


    }

    private void Left() // Girar a l'esquerra
    {
        if (rb.transform.position == carril2.transform.position)
        {

            // rb.AddForce(Vector2.left);
            //rb.transform.position = new Vector3(limitesq, -1, 0);

            rb.transform.position = new Vector3(carril1.transform.position.x, carril1.transform.position.y, 0);


        }
        else if (rb.transform.position == carril3.transform.position)
        {

            rb.transform.position = new Vector3(carril2.transform.position.x, carril2.transform.position.y, 0);

        }
    }




        //}

        void OnTriggerEnter2D(Collider2D other) // Colisi� Trigger 
        {

        if (other.gameObject.CompareTag("car")) // Si l'objecte amb el qual colisionem te un tag == "";
        {
            
            GameOverFuntion(); // Game Over
        }
      
        else if (other.gameObject.CompareTag("OilSpeed")) // Si l'objecte amb el qual colisionem te un tag == "";
        {
            gasoilsound.Play();
            gasolinascript.Sumargasolina();
            Destroy(other.gameObject);
            
    
        }
        else if (other.gameObject.CompareTag("coin")) // Si l'objecte amb el qual colisionem te un tag == "";
        {

            contadorcoins++; // Sumem la moneda
            coinssound.Play(); // So de la moneda
            coins.text = contadorcoins.ToString(); // Mostrem la suma
            Destroy(other.gameObject); // Destruim la moneda

        }


    }

   



    public void GameOverFuntion() {

        gameoversound.Play();

        sonidojuego.Stop();



        GameOverObject.SetActive(true); // Activem el canvas de GameOver

        finalcoins.text = contadorcoins.ToString() ;

        StopGame();// Parar tot
      
    }

    private void StopGame()
    {
        Time.timeScale = 0;
        stopGame = true;

        //speed.scrollspeed = 0; // Parem el scrolling 
        Destroy(SpawnCotxes); // Parar Cotxes
        Destroy(SpawnMonedes);
        //timer.SetActive(false); // Parem el timer

    }








}
