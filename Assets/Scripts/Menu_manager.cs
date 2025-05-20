using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_manager : MonoBehaviour
{
    public void LevelSelect()
    {
        SceneManager.LoadScene("Level-Selector");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void About()
    {
        SceneManager.LoadScene("About");
    }
}
