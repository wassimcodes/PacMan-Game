using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class GameManage : MonoBehaviour
{
    //score
    private int score = 0;
    public Text scoreText;

    public static GameManage instance;
    //door animation
    public GameObject door;
    public Animator doorAnimator;
   

   

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        doorAnimator.enabled = false;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        DoorOpen();

       
        
    }

    public void scoreIncreasing()
    {
        score++;
        scoreText.text = score.ToString().PadLeft(2, '0');
    }

    void DoorOpen()
    {
        if (score == 10)
        {
            door.GetComponent<Renderer>().material.color = Color.green;
            doorAnimator.enabled = true;
        }
    }

  



}
