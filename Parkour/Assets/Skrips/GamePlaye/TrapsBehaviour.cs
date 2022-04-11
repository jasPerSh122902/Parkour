using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _player;
    [SerializeField]
    private Transform _respawn_point;

    public Transform Player
    {
        get { return _player; }
        set { _player = value; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _player)
        {
            _player.transform.position = _respawn_point.transform.position;

        }
    }
}
