using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gamefunctions : MonoBehaviour
{
    public GameObject deathscreen;
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void quit()
    {
        Application.Quit();
    }
    public void gameover(){
        deathscreen.SetActive(true);
    }
}
