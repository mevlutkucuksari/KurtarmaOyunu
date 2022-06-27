using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public void baslangicekrani() 
    {
        SceneManager.LoadScene(0); 
        Time.timeScale = 1;
    }
    public void level1() 
    {
        SceneManager.LoadScene(1); 
        Time.timeScale = 1;
    }
    public void level2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void level3()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
   
    public void levelson()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
    }
    public void quit() 
    {
        Application.Quit();
    }

}
