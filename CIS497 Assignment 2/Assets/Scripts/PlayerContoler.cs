/* Logan Ross 
 * PlayerControler.cs 
 * Assignment 2 
 * checks for player input
 */

using UnityEngine;
using System.Collections;


    public class PlayerContoler : movement
    {

    public Rigidbody playerRB;

    // Update is called once per frame
    void Update()
        {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(getCanJump())
            {
                Debug.Log("jumping");
                jump(playerRB);
            }
        }

            if (getCanMove())
            {
                Debug.Log("moving");
                move(playerRB);
            }
    }
    }