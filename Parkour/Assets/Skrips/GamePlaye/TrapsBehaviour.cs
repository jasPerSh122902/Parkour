using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _player;
    [SerializeField]
    private int _damage;
    [SerializeField]
    private float _coolDown;
    private float _timer;

    public Transform Player
    {
        get { return _player; }
        set { _player = value; }
    }
    public void Update()
    {
        print("Timer" + _timer);
        _timer += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _player)
        {
            if (_coolDown < _timer)
            {
                PlayerBehaviour playerhealth = other.GetComponent<PlayerBehaviour>();
                if (playerhealth)
                    playerhealth.TakeDamage(_damage);

                _timer = 0;
            }
            
        }
    }
}
