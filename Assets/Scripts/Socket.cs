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
    private bool isGood1;
    private bool isGood2;
    private bool isGood3;
    private bool isGood4;

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
    void Update(){
        // Debug.Log(isGood1);
        // Debug.Log(isGood2);
        // Debug.Log(isGood3);
        // Debug.Log(isGood4); 

        //Appel cette fonction lorsque les 4 nametag sont dans les bons sockets
        // if(isGood1==true && isGood2==true && isGood3==true && isGood4 == true){
        //     SocketFinal();
        // }
        //Petite condition pour dire si la plaque est bien mis sur le bon socket, de disable son grab interactable
        // if(isGood1 == true){
        //     Invoke("AppelScriptJon", 3f);
        // }
        // if(isGood2 == true){
        //     Invoke("AppelScriptMat", 3f);
        // }
        // if(isGood3 == true){
        //     Invoke("AppelScriptOli", 3f);
        // }
        // if(isGood4== true){
        //     Invoke("AppelScriptZak", 3f);
        // }

    }
    public void SocketFinal(){
        key.SetActive(true);
        lumierePuzzle.AllumerLight(6);
        AllumerLumiereFinale();
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
        Validation();
    }
    void Validation(){
         if(isGood1==true && isGood2==true && isGood3==true && isGood4 == true){
            SocketFinal();
        }
    }

    void AppelScriptJon(){
        scriptNametagJonathan.DisableInteractable();
        _rbJon.constraints = RigidbodyConstraints.FreezePosition;
        _rbJon.constraints = RigidbodyConstraints.FreezeRotation;
        _rbJon.useGravity = false;
    }
    void AppelScriptOli(){
        scriptNametagOlivier.DisableInteractable();
        _rbOli.constraints = RigidbodyConstraints.FreezePosition;
        _rbOli.constraints = RigidbodyConstraints.FreezeRotation;
        _rbOli.useGravity = false;
    }
    void AppelScriptMat(){
        scriptNametagMathis.DisableInteractable();
        _rbMat.constraints = RigidbodyConstraints.FreezePosition;
        _rbMat.constraints = RigidbodyConstraints.FreezeRotation;
        _rbMat.useGravity = false;
    }
    void AppelScriptZak(){
        scriptNametagZakary.DisableInteractable();
        _rbZak.constraints = RigidbodyConstraints.FreezePosition;
        _rbZak.constraints = RigidbodyConstraints.FreezeRotation;
        _rbZak.useGravity = false;
    }

    public void AllumerLumiereFinale()
    {
        lumierePuzzle.AllumerLight(7);
    }
}
