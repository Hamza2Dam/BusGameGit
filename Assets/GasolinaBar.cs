using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GasolinaBar : MonoBehaviour
{
    public Slider slider; // Slider amb els valors de la barra
    public float deposit; // Deposit de gasolina
    public int treuregasolina = 15; // Valor que volem restar de gasolina
    public int sumargasolina = 30; // Valor que volem sumar de gasolina
    public PlayerController playerscript; // Script del PlayerController

    void Start()
    {
        deposit = 100; // Capacitat inicial del deposit 
        slider.value = deposit; // Asignem la capacitat al slider perque es mostri a la barra


    }

    private void Update()
    {
        Restargasolina(); // Restem la gasolina
        
    }





    public void Restargasolina()
    {


        deposit -= Time.deltaTime * treuregasolina; // Cada segon el temps restará el valor que hem asignat


        SetGasoil(deposit); // Li asignem el valor a la barra



        if (deposit < 0) // Si s'acaba la gasolina mors
        {

            playerscript.GameOverFuntion(); // GameOver
        }

    }
    public void SetGasoil(float gasolina)
    {

        // El valor de la barra es igual al valor que li passem
        slider.value = gasolina;



    }



    public void Sumargasolina()
    {
        if(deposit + sumargasolina < 100) // Si la suma de la gasolina no passa del màxim del depòsit sumarem la gasolina
        {
            deposit = deposit + sumargasolina; // Li sumem x a la gasolina
        }
        // Si la suma de la gasolina  passa del màxim del depòsit NO sumarem la gasolina si no que la deixarem a 100
        else
        {
            deposit = 100; 

            // Per exemple 89 + 25 = 114
            // Com el màxim es 100 deixem el dipòsit a 100
        }


    }



}
