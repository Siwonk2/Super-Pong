using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    void Awake(){

        if(instance == null){
            instance = this;
        }

        else{
            Destroy(gameObject);
            return;
        }


        DontDestroyOnLoad(gameObject);

        foreach(Sound s in sounds){
            s.setSource(gameObject.AddComponent<AudioSource>());
            s.getSource().clip = s.clip;
            s.getSource().volume = s.volume;
            s.getSource().pitch = s.pitch;
            s.getSource().loop = s.loop;
            
        }
    }

    

    public void play(string name){
        Sound s = Array.Find(sounds, sound=> sound.name == name);
        if(s == null){
            return;
        }
        s.getSource().Play();
    }

    void Start(){
        play("Menu_Theme");
    }

    public void stop(string name){
        Sound s = Array.Find(sounds, sound=> sound.name == name);
        if(s == null){
            return;
        }
        s.getSource().Stop();
    }

    public bool isPlaying(string name){
        Sound s = Array.Find(sounds, sound=> sound.name == name);
        if(s.getSource().isPlaying){
            return true;
        }
        else{
            return false;
        }
        
    }
}



