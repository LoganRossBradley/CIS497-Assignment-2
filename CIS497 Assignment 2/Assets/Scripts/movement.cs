/* Logan Ross 
 * movement.cs 
 * Assignment 2 
 * allows the player to move
 */

using UnityEngine;
using System.Collections;


    public class movement : MonoBehaviour
    {
    private bool canJump;
    private bool canMove;

    public float horizontalInput;
    public float verticalInput;

    public void jump(Rigidbody playerRB)
    {
        gameObject.transform.position = new Vector2(transform.position.x, transform.position.y + (3));
    }
    public void move(Rigidbody playerRB)
    {
        /*horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        if ((horizontalInput != 0 || verticalInput != 0))
        {

            playerRB.AddForce(transform.forward * 10, ForceMode.Force);

            //transform.rotation = Quaternion.LookRotation(movement);
        }*/
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        gameObject.transform.position = new Vector2(transform.position.x + (horizontalInput),transform.position.y);
    }
    public bool getCanJump()
    {
        return canJump;
    }
    public bool getCanMove()
    {
        return canMove;
    }
    public void setCanJump(bool newVal)
    {
        canJump = newVal;
    }
    public void setCanMove(bool newVal)
    {
        canMove = newVal;
    }
}