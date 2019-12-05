//game over UI
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameoverUI : MonoBehaviour
{
    //quit button
    public void Quit()
    {
        Application.Quit();
    }
    //retart button
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
