using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] private HingeJoint hJ;
    [SerializeField] private PortesSousSol pS;
    [SerializeField] private LumierePuzzle pLight;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioClip _sonLever;

    private bool dejaActiver = false;
    // Start is called before the first frame update
    void Start()
    {
        hJ=GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        ActiverLevier();
    }

    private void ActiverLevier(){
        if(hJ.angle >= 170){
            pS.DebarrerPorteSousSol();
            pLight.AllumerLight(4);
            if(dejaActiver == false){
                dejaActiver = true;
                _audio.PlayOneShot(_sonLever);
            }
        }
    }
}
