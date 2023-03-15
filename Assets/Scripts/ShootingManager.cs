using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingManager : MonoBehaviour
{
    [SerializeField] AudioClip shootingSFX;
    [SerializeField] AudioClip cointossSFX;
    [SerializeField] float fireRate = 0.3f;
    AudioSource audioSource;

    bool isFiring = false;

    private void Start()
    {
            audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            isFiring = true;
            InvokeRepeating("PlaySound", 0f, fireRate);
        }
        else if(Input.GetButtonUp("Fire1"))
        {
            //audioSource.Stop();
            audioSource.PlayOneShot(cointossSFX);
            isFiring = false;
            CancelInvoke("PlaySound");
        }
    }

    void PlaySound()
    {
        audioSource.PlayOneShot(shootingSFX);
    }
}
