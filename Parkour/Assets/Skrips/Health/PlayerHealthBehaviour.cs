using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBehaviour : MonoBehaviour
{
    [SerializeField]
    private Text _healthText;
    [SerializeField]
    private PlayerBehaviour _player;

    // Update is called once per frame
    void Update()
    {
        ////this could be cleaned up by putting this in the take damage function
        float health = _player.Lives;
        if (health < 0) health = 0;
        _healthText.text = "Lives Used: " + health;
        //print(health);
    }
}
