using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GasolinaBar : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    
    public void Fullbar(int gasolina) 
    {
        slider.maxValue = gasolina;
        slider.value = gasolina;
    
    }

    public void SetGasoil(int gasolina) 
    {

        slider.value = slider.value +  gasolina;
    
    }
}
