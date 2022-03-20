using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Shop()
    {
        SceneManager.LoadScene("ShopScene");
    }
    public void Settings()
    {
        SceneManager.LoadScene("SettingsScene");
    }
    public void Exit()
    {
        Application.Quit();
    }




}
