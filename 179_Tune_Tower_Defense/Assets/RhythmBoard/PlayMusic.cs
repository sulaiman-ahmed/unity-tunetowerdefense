using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onCollisionEnter(Collision collision) {
        // if(!music.isPlaying) {
        //     music.Play();
        // }
        music.Play();
    }
}
