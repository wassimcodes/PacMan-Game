using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorScript : MonoBehaviour
{
    public void LevelOne()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void LevelTwo()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void backToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
