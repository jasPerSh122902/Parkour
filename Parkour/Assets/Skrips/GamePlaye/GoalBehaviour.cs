using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoalBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _goaler;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _goaler)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
