using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] private HingeJoint hJ;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioClip _sonLever;
    [SerializeField] private GameObject _Statue;

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
        if(hJ.angle >= 90){
            _Statue.transform.Rotate(0,0,1f);
            if(dejaActiver == false){
                dejaActiver = true;
                _audio.PlayOneShot(_sonLever);
            }
        }
    }
}
