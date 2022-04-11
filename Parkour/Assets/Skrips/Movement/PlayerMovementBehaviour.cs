using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _goal;
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;

    public Vector3 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();

    }
    //update
    private void FixedUpdate()
    {
        //tells the rigidbody to move to a position
        Vector3 velocity = MoveDirection * _speed * Time.deltaTime;
        _rigidbody.MovePosition(transform.position + velocity);

        //print(velocity.x);
        //print(velocity.y);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (transform == _goal)
        {
            Destroy(_goal);

        }
    }
}