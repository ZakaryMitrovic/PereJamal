using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Lighter : MonoBehaviour
{
    [SerializeField] private GameObject _fire;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioClip _sonAllumer;
    public XRDirectInteractor rHand, lHand;
    public GameObject _leftHand;
    public GameObject _rightHand;

    public void Allumer()
    {
        _fire.SetActive(true);
        _audio.PlayOneShot(_sonAllumer);

        if(lHand.hasSelection == true){
            _leftHand.SetActive(true);
        }else if(rHand.hasSelection == true){
            _rightHand.SetActive(true);
        }else{
            _leftHand.SetActive(false);
            _rightHand.SetActive(false);
        }
        
    }

    public void Eteindre()
    {
        _fire.SetActive(false);
        _leftHand.SetActive(false);
        _rightHand.SetActive(false);
    }
}
