using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plates : MonoBehaviour
{
    [SerializeField] private GameObject[] plates;
    [SerializeField] private AudioSource _audioPlaque1;
    [SerializeField] private AudioSource _audioPlaque2;
    [SerializeField] private AudioSource _audioPlaque3;
    [SerializeField] private AudioSource _audioPlaque4;
    [SerializeField] private AudioClip _sonPressure;
    [SerializeField] private LumierePuzzle _light;
    [SerializeField] private Rigidbody[] _rbLevier;
    [SerializeField] private TurnTable _disque;

    private bool isGood1;
    private bool isGood2;
    private bool isGood3;
    private bool isGood4;
    public bool isAtPuzzle3;
    // Start is called before the first frame update
    void Start()
    {
        isAtPuzzle3 = false;
        isGood1 = false;
        isGood2 = false;
        isGood3 = false;
        isGood4 = false;

        for(int i=0; i<_rbLevier.Length; i++){
            _rbLevier[i].freezeRotation = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PeserPlaque1(){
        if(isAtPuzzle3==true){
            Debug.Log("LOL1");
            isGood1=true;
            _audioPlaque1.PlayOneShot(_sonPressure);
        }
        Validation();
    }
    public void PeserPlaque2(){
        if(isAtPuzzle3==true){
        Debug.Log("LOL2");
        isGood2=true;
        _audioPlaque2.PlayOneShot(_sonPressure);}
        Validation();
    }
    public void PeserPlaque3(){
        if(isAtPuzzle3==true){
        Debug.Log("LOL3");
        isGood3=true;
        _audioPlaque3.PlayOneShot(_sonPressure);}
        Validation();
    }
    public void PeserPlaque4(){
        if(isAtPuzzle3==true){
        Debug.Log("LOL4");
        isGood4=true;
        _audioPlaque4.PlayOneShot(_sonPressure);}
        Validation();
    }

    public void Validation(){
        if(isGood1 == true){
            if(isGood2 == true){
                if(isGood3 == true){
                    if(isGood4 == true){
                        for(int i=0; i<_rbLevier.Length; i++){
                            _rbLevier[i].freezeRotation = false;
                        }
                        _light.AllumerLight(3);
                        _disque.JouerAudio();
                    }
                }else if(isGood4 == true){
                    isGood1=false;
                    isGood2=false;
                    isGood3=false;
                    isGood4=false;
                }
            }else if(isGood4 == true || isGood3==true){
                isGood1=false;
                isGood2=false;
                isGood3=false;
                isGood4=false;
            }
        }else{
            isGood1=false;
            isGood2=false;
            isGood3=false;
            isGood4=false;
        }
    }
}
