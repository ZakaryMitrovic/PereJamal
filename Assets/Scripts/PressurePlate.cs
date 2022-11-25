using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private LumierePuzzle _light;
    [SerializeField] private Rigidbody[] _rbLevier;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioClip _sonPressure;

    void Start(){
        for(int i=0; i<_rbLevier.Length; i++){
            _rbLevier[i].freezeRotation = true;
        }
    }

    public bool isAtPuzzle3 = false;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && isAtPuzzle3 == true)
        {
            _light.AllumerLight(3);
            _audio.PlayOneShot(_sonPressure);
            for(int i=0; i<_rbLevier.Length; i++){
            _rbLevier[i].freezeRotation = false;
        }
        }
    }
}
