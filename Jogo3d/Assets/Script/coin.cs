using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Contador coinCounter = GameObject.FindObjectOfType<Contador>();
        if (other.gameObject.tag == "Player")
        {
            source.Play();
            coinCounter.AddCoin();
            Destroy(gameObject, 0.4f);
        }
    }
}
