using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    private AudioSource music;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        music = GetComponent<AudioSource>();
    }

    public void playMusic()
    {
        if (music.isPlaying) return;
        music.Play();
    }

    public void stopMusic()
    {
        music.Stop();
    }


}
