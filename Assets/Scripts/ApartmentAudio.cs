using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApartmentAudio : MonoBehaviour
{
    public GameObject cube;

    public AudioClip[] audioClipArray;
    private AudioSource source;


    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            source.clip = audioClipArray[0];
            source.PlayOneShot(source.clip);
            source.Play();
        }
    }

}
