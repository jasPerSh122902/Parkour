using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InputBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour _playerMovement;
    private int myHorizontal;
    private int myVertical;
    private bool pressCheck;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovementBehaviour>();
    }

     void Update()
     {
        if (!pressCheck)
        {
            myHorizontal = 0;
            myVertical = 0;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow)) 
        {
            myHorizontal = (int)Input.GetAxisRaw("HorizontalArrow");
            myVertical = (int)Input.GetAxisRaw("VerticalArrow");
        }

        _playerMovement.MoveDirection = new Vector3(myHorizontal, myVertical, 0).normalized;
     }

    public void PressRight() 
    {
        myHorizontal = 1;
        pressCheck = true;
    }
    public void UnpressRight()
    {
        pressCheck = false;
    }
    public void PressLeft()
    {
        myHorizontal = -1;
        pressCheck = true;
    }
    public void UnpressLeft()
    {
        pressCheck = false;
    }
    public void PressUp()
    {
        myVertical = 1;
        pressCheck = true;
    }
    public void UnpressUp()
    {
        pressCheck = false;
    }
}