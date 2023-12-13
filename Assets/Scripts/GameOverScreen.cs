using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    void Start()
    {
        // if (SceneManager.GetActiveScene().name == "Final")
        // {
        //     Cursor.visible = true;
        // }
         
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Dog")
        {
            if(PlayerPrefs.GetInt("level", 1)  < SceneManager.GetActiveScene().buildIndex + 1)
            {
                PlayerPrefs.SetInt("level", SceneManager.GetActiveScene().buildIndex + 1);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Scene_1");
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
