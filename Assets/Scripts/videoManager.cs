using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoManager : MonoBehaviour
{
    public VideoPlayer video;

    public void playVideo()
    {
        video.Play();
    }

    public void stopVideo()
    {
          video.Pause();
    }
}
