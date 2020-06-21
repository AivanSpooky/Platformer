using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager: MonoBehaviour
{
    public Sound[] sounds; 
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;

            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;

        }
    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
