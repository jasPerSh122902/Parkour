using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private Camera _camera;
    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _camera = Camera.main;
    }

    private void FixedUpdate()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            Vector3 direction = (hitInfo.point - transform.position).normalized;
            direction = new Vector3(direction.x, 0, direction.z);
            _rigidbody.velocity = direction * _speed * Time.fixedDeltaTime;

        }
    }
}
