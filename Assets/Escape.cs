using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Escape : MonoBehaviour
{
    [SerializeField] GameObject escapeButton;

    [SerializeField] GameObject emptyBase;
    [SerializeField] GameObject emptySail;
    [SerializeField] GameObject emptyFood;
    [SerializeField] GameObject emptySpane;

    [SerializeField] GameObject base1;
    [SerializeField] GameObject base2;
    [SerializeField] GameObject base3;

    [SerializeField] GameObject sail1;
    [SerializeField] GameObject sail2;
    [SerializeField] GameObject sail3;

    [SerializeField] GameObject food1;
    [SerializeField] GameObject food2;
    [SerializeField] GameObject food3;

    [SerializeField] GameObject spane1;
    [SerializeField] GameObject spane2;
    [SerializeField] GameObject spane3;

    public VideoPlayer videoPlayer;
    public VideoClip escape1;
    public VideoClip escape2;
    public VideoClip escape3;

    // Start is called before the first frame update
    public void TryEscape () 
    {
        int escapeNumber = PlayerPrefs.GetInt("escapeAttempts", 1);

        Debug.Log("Escape number: " + escapeNumber.ToString());
        PlayerPrefs.SetInt("escapeAttempts", Mathf.Min(escapeNumber + 1, 2));
        //based on which escape, play another video

        videoPlayer.Stop();
        videoPlayer.targetCameraAlpha = 1f;
        switch (escapeNumber)
        {
            case 0:
                videoPlayer.clip = escape1;
                videoPlayer.Play();
                break;
            case 1:
                videoPlayer.clip = escape2;
                videoPlayer.Play();
                break;
            case 2:
                videoPlayer.clip = escape3;
                videoPlayer.Play();
                break;
            default:
                Debug.LogError("Something went horribly wrong with the escape video");
                videoPlayer.clip = escape1;
                videoPlayer.Play();
                break;
        }

        base1.SetActive(false);
        sail1.SetActive(false);
        food1.SetActive(false);
        spane1.SetActive(false);
        base2.SetActive(false);
        sail2.SetActive(false);
        food2.SetActive(false);
        spane2.SetActive(false);
        base3.SetActive(false);
        sail3.SetActive(false);
        food3.SetActive(false);
        spane3.SetActive(false);

        escapeButton.SetActive(false);

        emptyBase.SetActive(true);
        emptySail.SetActive(true);
        emptyFood.SetActive(true);
        emptySpane.SetActive(true);
    }

    public void Update()
    {
        if ((videoPlayer.isPlaying && videoPlayer.time >= videoPlayer.clip.length - 0.1f))
        {
            videoPlayer.targetCameraAlpha = 0f;
            videoPlayer.Stop();
        }
    }
}
