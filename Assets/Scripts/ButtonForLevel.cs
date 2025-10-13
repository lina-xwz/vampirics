using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ButtonForLevel : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }

    public void StartLevel1()
    {
        SceneManager.LoadScene("level1");
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene("level2");
    }

    public void StartLevel3()
    {
        SceneManager.LoadScene("level3");
    }
}
