using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InputBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour _playerMovement;
    private int myHorizontal, myVertical;
    private bool pressCheck;

    private void Awake()
    {
        //when awake is called get the compnent of player movement behaviour.
        _playerMovement = GetComponent<PlayerMovementBehaviour>();
    }

     void Update()
     {
        if (!pressCheck)
        {
            //defaults the values to 0 when not pressed.
            myHorizontal = 0;
            myVertical = 0;
        }
        //If these Keys are pressed
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow)) 
        {
            //gets the horizontal or vertical raws.
            myHorizontal = (int)Input.GetAxisRaw("HorizontalArrow");
            myVertical = (int)Input.GetAxisRaw("VerticalArrow");
        }
        //adds a  vector3 that is my horizontal and verticalinputs to the movedirection.
        _playerMovement.MoveDirection = new Vector3(myHorizontal, myVertical, 0).normalized;
     }

    //is the Right key is pressed down.
    public void PressRight() 
    {
        myHorizontal = 1;
        pressCheck = true;
    }
    //The Right Key is not pressed.
    public void UnpressRight()
    {
        pressCheck = false;
    }
    //The Left key is pressed down.
    public void PressLeft()
    {
        myHorizontal = -1;
        pressCheck = true;
    }
    //The Left Key is not pressed.
    public void UnpressLeft()
    {
        pressCheck = false;
    }
    //The Up Key is pressed down
    public void PressUp()
    {
        myVertical = 1;
        pressCheck = true;
    }
    //The Up key is not pressed
    public void UnpressUp()
    {
        pressCheck = false;
    }
}