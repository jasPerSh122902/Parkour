using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;

    
    public Vector3 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }

    /// <summary>
    /// when awake is called for players movement behaviour add a componet of rigidbody type
    /// </summary>
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    //update
    private void FixedUpdate()
    {
        //print("I am here");
        //tells the rigidbody to move to a position
        Vector3 velocity = MoveDirection * _speed * Time.deltaTime;
        _rigidbody.MovePosition(transform.position + velocity);
    }

    private void OnTriggerEnter(Collider other)
    {  }
}