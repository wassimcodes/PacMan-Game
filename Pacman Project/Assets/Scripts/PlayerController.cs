using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;
    
    public bool canMove = true;
    public Animator animator;
 


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            playerMovement();
        }

        if( Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) )
            {
            animator.enabled = false;
        }
        else
            if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            animator.enabled = true;
        }



    }

   public    void playerMovement()
    {
      float xMovement = Input.GetAxis("Horizontal");
      float yMovement = Input.GetAxis("Vertical");

        transform.position += new Vector3 (xMovement * movementSpeed * Time.deltaTime, yMovement * movementSpeed * Time.deltaTime, transform.position.z);



    }
}
