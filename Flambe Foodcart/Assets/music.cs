using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{



    public AudioClip menu;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = menu;
        audioSource.loop = true;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
