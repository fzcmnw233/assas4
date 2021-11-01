using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource IntroMusic;
    public AudioSource StartMusic;
	
	
	
    void Start()
    {
        StartMusic.Stop();
        IntroMusic.Play();
    }


    void Update()
    {  
		if((int)Time.time==8)
        {   
			 IntroMusic.Stop(); 
            if(!IntroMusic.isPlaying)
            {
                if(!StartMusic.isPlaying)
                {
                    StartMusic.Play();
                }  
            }    
		}			
    }
}