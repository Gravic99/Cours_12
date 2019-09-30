using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

    public AudioClip Rire;
    private MusicPlayer musicPlayer;
    // Use this for initialization
    void Start () {
        musicPlayer = FindObjectOfType<MusicPlayer>();
        
	}
	public void OnTriggerEnter(Collider gameObject)
    {
        musicPlayer.GetComponent<AudioSource>().PlayOneShot(Rire);
    }
}
