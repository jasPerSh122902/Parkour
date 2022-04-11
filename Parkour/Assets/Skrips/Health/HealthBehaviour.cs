using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    [SerializeField]
    private int _lives = 0;
    [SerializeField]
    private bool _isAlive;
    [SerializeField]
    private bool _distroyOnDeath;
    private PlayerMovementBehaviour _player;
    private Rigidbody _rigidbody;

    public int Lives
    {
        get { return _lives; }
    }
    public bool IsAlive
    {
        get { return _isAlive; }
    }

    public  int TakeDamage(int damageAmount)
    {
        _lives += damageAmount;

        return damageAmount;
    }
    public virtual void OnDeath()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _isAlive = _lives > 0;

        if (!IsAlive && _distroyOnDeath)
            OnDeath();
    }
}
