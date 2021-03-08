/* Logan Ross 
 * GameManager.cs 
 * Assignment 2 
 * controls the scene's buttons
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


    public class GameManager : MonoBehaviour
    {
    public GameObject playerObject;
    public movement movementScript;
    public Text jumpText;
    public Text movementText;

    private void Start()
    {
       movementScript = playerObject.GetComponent<movement>();
    }

    private void Update()
    {
        movementText.text = "Movement: "+ movementScript.getCanMove();
        jumpText.text = "Jump: " + movementScript.getCanJump();
    }

    public void toggleJump()
    {
        bool jumpAbility = movementScript.getCanJump();
        movementScript.setCanJump(!jumpAbility);
    }
    public void toggleMove()
    {
        bool walkAbility = movementScript.getCanMove();
        movementScript.setCanMove(!walkAbility);
    }

    public void resetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    }