using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSource : MonoBehaviour
{

    public AudioClip BackgroundMusicClip;


    // Start is called before the first frame update
    void Awake()
    {
        if (GameObject.FindFirstObjectByType<BGMSource>().gameObject != this.gameObject) { 
        
            Destroy(this.gameObject);
            return;
        
        }
        DontDestroyOnLoad(gameObject);
        AudioSource src = GetComponent<AudioSource>(); 
        src.clip = BackgroundMusicClip;
        src.loop = true; 
        if(!src.isPlaying) src.Play();


    }
}
