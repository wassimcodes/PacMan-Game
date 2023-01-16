using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class SmallMenuScript : MonoBehaviour
{
    public GameObject smallPanel;
    public bool isActive;
    private GameObject mainCam;
    //getting access to the timer panel
    public GameObject timer;
    //getting access to the character obj
    public GameObject player;
    //getting access to hearts
    public GameObject heart;



    void Start()
    {
        //turning off the small panel
        smallPanel.SetActive(false);
        //getting access to the main camera
        mainCam = GameObject.Find("Main Camera");
        mainCam.GetComponent<PostProcessVolume>().enabled = false;
        //getting acces to the timer script
    }

    
    void Update()
    {
        SmallMenu();
    }

   void SmallMenu()
    {
        //toggle the panel on and off 
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isActive = !isActive;

        }
        //when the panel is on
        if(isActive)
        {
            smallPanel.SetActive(true);
            mainCam.GetComponent<PostProcessVolume>().enabled = true;
            timer.GetComponent<TimerScript>().TimerOn = false;
            player.GetComponent<PlayerController>().canMove = false;
            heart.SetActive(false);
            player.SetActive(false);
        }
        //when teh panel is off
        if (!isActive)
        {
            smallPanel.SetActive(false);
            mainCam.GetComponent<PostProcessVolume>().enabled = false;
            timer.GetComponent<TimerScript>().TimerOn = true;
            player.GetComponent<PlayerController>().canMove = true;
            heart.SetActive(true);
            player.SetActive(true);

        }
    }
}
