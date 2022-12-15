using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private bool alreadyOnPlay = false;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && alreadyOnPlay == false){
            Debug.Log("ee");
            CommencerMusique();
            alreadyOnPlay = true;
        }
    }

    private void CommencerMusique()
    {
        GetComponent<AudioSource>().Play();
    }
}
