using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Key : MonoBehaviour
{
    public XRDirectInteractor rHand, lHand;
    public GameObject _leftHand;
    public GameObject _rightHand;
    // Start is called before the first frame update
    void Start()
    {
        _leftHand.SetActive(false);
        _rightHand.SetActive(false);
    }

    public void AjoutMain(){
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
