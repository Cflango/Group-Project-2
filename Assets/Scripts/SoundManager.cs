using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip chase, lose, patrol, spawn, endchase;
    static AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        chase = Resources.Load<AudioClip>("chase");
        lose = Resources.Load<AudioClip>("lose");
        patrol = Resources.Load<AudioClip>("patrol");
        spawn = Resources.Load<AudioClip>("spawn");
        endchase = Resources.Load<AudioClip>("endchase");
    }


    // Play sound when player shoots or mushroom and centipede dies
    public static void Play(string clip)
    {
        switch (clip)
        {
            case "chase": source.PlayOneShot(chase); break;
            case "lose": source.PlayOneShot(lose); break;
            case "patrol": source.PlayOneShot(patrol); break;
            case "spawn": source.PlayOneShot(spawn); break;
            case "endchase": source.PlayOneShot(endchase); break;
        }
    }
}