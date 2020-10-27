using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MenuVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.targetCameraAlpha = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if((videoPlayer.isPlaying && videoPlayer.time >= videoPlayer.clip.length - 0.1f) || Input.GetKeyDown(KeyCode.Space))
        {
            videoPlayer.targetCameraAlpha = 0f;
            videoPlayer.Stop();
        }
    }

    public void PlayStory()
    {
        videoPlayer.Play();
        videoPlayer.targetCameraAlpha = 1f;
    }
}
