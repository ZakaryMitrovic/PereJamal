using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Lever : MonoBehaviour
{
    [SerializeField] private HingeJoint hJ;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioSource _audioStatue;
    [SerializeField] private AudioClip _sonLever;
    [SerializeField] private GameObject _Statue;
    public XRDirectInteractor rHand, lHand;
    public GameObject _leftHand;
    public GameObject _rightHand;
    public GameObject _montre;
    public GameObject _timer;


    private bool dejaActiver = false;
    // Start is called before the first frame update
    void Start()
    {
        hJ=GetComponent<HingeJoint>();
        _leftHand.SetActive(false);
        _rightHand.SetActive(false);
        _audioStatue.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(hJ.angle >= 90){
            _Statue.transform.Rotate(0,0,1f);
            _audioStatue.enabled = true;
            if(dejaActiver == false){
                dejaActiver = true;
                _audio.PlayOneShot(_sonLever);
            }
        }else{
            _audioStatue.enabled = false;
        }
    }

    public void ActiverLevier(){
        if(lHand.hasSelection == true){
            _leftHand.SetActive(true);
            _montre.GetComponent<Renderer>().enabled = false;
            _timer.GetComponent<Renderer>().enabled = false;
        }if(rHand.hasSelection == true){
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
