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
        //if the trasform is the goalers transform
        if (other.transform == _goaler)
        {
            //load the scene that is next
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
