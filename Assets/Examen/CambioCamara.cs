using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    public CinemachineVirtualCamera cam;
    bool cambio;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        cam = GameObject.Find("SegundaCamara").GetComponent<CinemachineVirtualCamera>(); ;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Personaje" && cam.Priority == 5)
        {
            cam.Priority = 15;
            audioSource.Play();
        }
        else if (collision.gameObject.tag == "Personaje" && cam.Priority == 15) 
        { 
            cam.Priority = 5;
            audioSource.Play();
        }
    }
}
