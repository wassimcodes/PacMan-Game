using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void selectLevel()
    {
        SceneManager.LoadScene("Level Selector");
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
