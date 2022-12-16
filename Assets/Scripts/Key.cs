using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Key : MonoBehaviour
{
    public XRDirectInteractor rHand, lHand;
    public GameObject _leftHand;
    public GameObject _rightHand;
    public GameObject _montre;
    public GameObject _timer;
    // Start is called before the first frame update
    void Start()
    {
        _leftHand.SetActive(false);
        _rightHand.SetActive(false);
    }

    public void AjoutMain(){
        if(lHand.hasSelection == true){
            _leftHand.SetActive(true);
            _montre.GetComponent<Renderer>().enabled = false;
            _timer.GetComponent<Renderer>().enabled = false;
        }
        if(rHand.hasSelection == true){
            _rightHand.SetActive(true);
        }
    }
    public void EnleverMain(){
        _leftHand.SetActive(false);
        _rightHand.SetActive(false);
        _montre.GetComponent<Renderer>().enabled = true;
        _timer.GetComponent<Renderer>().enabled = true;
    }
}
