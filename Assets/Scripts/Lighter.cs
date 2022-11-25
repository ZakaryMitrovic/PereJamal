using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{
    [SerializeField] private GameObject _fire;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioClip _sonAllumer;

    public void Allumer()
    {
        _fire.SetActive(true);
        _audio.PlayOneShot(_sonAllumer);
    }

    public void Eteindre()
    {
        _fire.SetActive(false);
    }
}
