using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    public AudioSource[] musicTracks;

    public int currentTrack;

    public bool musicCanPlay = true;

    private void Start()
    {
        musicCanPlay = true; 
    }

    void Update()
    {
        if (musicCanPlay)
        {
            if (!musicTracks[currentTrack].isPlaying)
            {
                musicTracks[currentTrack].Play();
            }
        }
        else
        {
            musicTracks[currentTrack].Stop();
        }

    }
    public void SwitchTrack(int newTrack)
    {
        musicTracks[currentTrack].Stop();
        currentTrack = newTrack;
        musicTracks[currentTrack].Play();
    }
}
