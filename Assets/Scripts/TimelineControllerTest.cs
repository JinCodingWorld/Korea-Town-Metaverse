using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineControllerTest : MonoBehaviour
{
    public PlayableDirector playableDirector;

    private void Update()
    {
        if(Input.anyKeyDown)
        {
            playableDirector.gameObject.SetActive(true);
            playableDirector.Play();
        }
    }
}
