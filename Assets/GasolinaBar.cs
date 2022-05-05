using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GasolinaBar : MonoBehaviour
{
    public Slider slider;
    public float deposit;
    public int treuregasolina = 5;
    public PlayerController playerscript;

    void Start()
    {
        deposit = 100;
        slider.value = deposit;


    }

    private void Update()
    {
        Restargasolina();
        Debug.Log(deposit);
    }



    public void SetGasoil( float gasolina) 
    {
        
        slider.value = gasolina;
        
 
    
    }

    public void Restargasolina()
    {


        deposit -= Time.deltaTime * treuregasolina; // Cada segon el temps restará el valor que hem asignat


        SetGasoil(deposit); // Li asignem el valor a la barra



        if (deposit < 0) // Si s'acaba la gasolina mors
        {

            playerscript.GameOverFuntion();
        }

    }

    public void Sumargasolina()
    {


        deposit = deposit + 25; // Li sumem 20 a la gasolina


    }



}
