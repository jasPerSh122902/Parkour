using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InputBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour _playerMovement;
    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovementBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerMovement.MoveDirection = new Vector3(Input.GetAxisRaw("HorizontalArrow"), Input.GetAxisRaw("VerticalArrow"), 0).normalized;
        
    }
}