using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
    [SerializeField] private GameObject _statue1;
    [SerializeField] private GameObject _statue2;
    [SerializeField] private GameObject _statue3;
    [SerializeField] private GameObject _statue4;

    [SerializeField] private PortesSousSol pS;
    [SerializeField] private LumierePuzzle pLight;
    [SerializeField] private AudioSource pSAudio;
    [SerializeField] private AudioClip SonPorte;

    bool isGood1;
    bool isGood2;
    bool isGood3;
    bool isGood4;
    // Start is called before the first frame update
    void Start()
    {
        isGood1 = false;
        isGood2 = false;
        isGood3 = false;
        isGood4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckStatues();
        Validation();
        Debug.Log("IsGood1: "+isGood1);
        //Debug.Log("IsGood2: "+isGood2);
        //Debug.Log("IsGood3: "+isGood3);
        //Debug.Log("IsGood4: "+isGood4);
        Debug.Log(_statue1.transform.rotation.z);
    }

    void CheckStatues(){
        //Quelque des statues on besoin de leur angles negative car sinon on doit faire un tour avant de pouvoir les mettre a true

        //NORD
        if (_statue1.transform.rotation.z >= 0.6 && _statue1.transform.rotation.z <= 0.8 || _statue1.transform.rotation.z >= -0.8 && _statue1.transform.rotation.z <= -0.6){
            isGood1 = true;
        }else{
            isGood1 = false;
        }

        //SUD
        if (_statue2.transform.rotation.z >= -0.2 && _statue2.transform.rotation.z <= 0.2){
            isGood2 = true;
        }else{
            isGood2 = false;
        }

        //OUEST
        if (_statue3.transform.rotation.z >= 0.2 && _statue3.transform.rotation.z <= 0.6 || _statue3.transform.rotation.z >= -0.6 && _statue3.transform.rotation.z <= -0.2){
            isGood3 = true;
        }else{
            isGood3 = false;
        }

        //EST
        if (_statue4.transform.rotation.z >= 0.3 && _statue4.transform.rotation.z <= 0.6 || _statue4.transform.rotation.z >= -0.6 && _statue4.transform.rotation.z <= -0.3){
            isGood4 = true;
        }else{
            isGood4 = false;
        }
    }

    void Validation(){
        if (isGood1 == true && isGood2 == true && isGood3 == true && isGood4 == true){
            pS.DebarrerPorteSousSol();
            pSAudio.PlayOneShot(SonPorte);
            pLight.AllumerLight(4);
        }
    }
}
