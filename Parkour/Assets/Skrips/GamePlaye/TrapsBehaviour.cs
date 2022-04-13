using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _player;
    [SerializeField]
    private Transform _respawn_point;
    [SerializeField]
    private HealthBehaviour healthBehaviour;

    public Transform Player
    {
        get { return _player; }
        set { _player = value; }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if the transfor and the given players transform equal to each other
        if (other.transform == _player)
        {
            //make the players transform position the respawns position.
            _player.transform.position = _respawn_point.transform.position;
            //makes the lives go up by one
            healthBehaviour.increaseLife(1);
        }
    }
}
