using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Nametag : MonoBehaviour
{
    public XRDirectInteractor rHand, lHand;
    public GameObject _leftHand;
    public GameObject _rightHand;
    public XRGrabInteractable _grab;

    public void DisableInteractable(){
        _grab.enabled = false;
    }

    public void ActiverMain(){
        if(lHand.hasSelection == true){
            _leftHand.SetActive(true);
        }else if(rHand.hasSelection == true){
            _rightHand.SetActive(true);
        }else{
            _leftHand.SetActive(false);
            _rightHand.SetActive(false);
        }
    }
    public void EnleverMain(){
        _leftHand.SetActive(false);
        _rightHand.SetActive(false);
    }
}

