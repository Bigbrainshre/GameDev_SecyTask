using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_selector : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("Level-1");
    }
    public void level2()
    {
        SceneManager.LoadScene("Level-2");
    }
    public void level3()
    {
        SceneManager.LoadScene("Level-3");
    }
    public void level4()
    {
        SceneManager.LoadScene("Level-4");
    }
    public void level5()
    {
        SceneManager.LoadScene("Boss-Battle");
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
