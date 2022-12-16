using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour
{
    [SerializeField] private GameObject[] socket;
    [SerializeField] private GameObject key;
    [SerializeField] private LumierePuzzle lumierePuzzle;
    [SerializeField] public Rigidbody _rbJon;
    [SerializeField] public Rigidbody _rbOli;
    [SerializeField] public Rigidbody _rbMat;
    [SerializeField] public Rigidbody _rbZak;
    [SerializeField] public AudioSource _audio;
    [SerializeField] public AudioClip _succeed;
    private bool isGood1;
    private bool isGood2;
    private bool isGood3;
    private bool isGood4;
    private bool _puzzleReussi;
    public Nametag scriptNametagJonathan;
    public Nametag scriptNametagOlivier;
    public Nametag scriptNametagMathis;
    public Nametag scriptNametagZakary;



    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
        isGood1 = false;
        isGood2 = false;
        isGood3 = false;
        isGood4 = false;
    }
    
    public void SocketFinal(){
        _puzzleReussi = true;
        key.SetActive(true);
        lumierePuzzle.AllumerLight(6);
        AllumerLumiereFinale();
        _audio.PlayOneShot(_succeed);
    }

    public void OnTriggerEnter(Collider other){

        if(socket[0] == other.CompareTag("J")){
            isGood1=true;
        }

        if(socket[1] == other.CompareTag("M")){
            isGood2=true;
        }

        if(socket[2] == other.CompareTag("O")){
            isGood3=true;
        }

        if(socket[3] == other.CompareTag("Z")){
            isGood4=true;
        }
        if(_puzzleReussi == false){
            Validation(); 
        }
    }
    void Validation(){
        if(isGood1==true && isGood2==true && isGood3==true && isGood4 == true){
            SocketFinal();
        }
    }

    public void AllumerLumiereFinale()
    {
        lumierePuzzle.AllumerLight(7);
    }
}
