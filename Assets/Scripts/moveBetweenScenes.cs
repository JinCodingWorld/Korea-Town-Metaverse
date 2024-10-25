using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveBetweenScenes : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bugchonmunhwa"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
