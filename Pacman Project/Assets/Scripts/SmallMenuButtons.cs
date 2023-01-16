using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmallMenuButtons : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
