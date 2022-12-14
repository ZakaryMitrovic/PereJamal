using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    [SerializeField] Animator _anim;
    [SerializeField] GameObject _briquet;
    [SerializeField] AudioClip[] _note;
    [SerializeField] AudioSource _audio;
    [SerializeField] LumierePuzzle _lumierePuzzle;

    private bool isGood1;
    private bool isGood2;
    private bool isGood3;
    private bool isGood4;

    string[] notes = {"Do", "Re", "Mi", "Fa", "Sol", "La", "Si"};

    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        _anim.GetComponent<Animator>();
        _briquet.SetActive(false);
        isGood1 = false;
        isGood2 = false;
        isGood3 = false;
        isGood4 = false;
    }

    public void JouerNote(int noteIndex){
        _anim.SetTrigger(notes[noteIndex]);
        _audio.PlayOneShot(_note[noteIndex]);

        if(noteIndex == 0){
            Debug.Log("DO");
            isGood1=true;
        }
        if(noteIndex == 5){
            Debug.Log("LA");
            isGood2=true;
        }
        if(noteIndex == 2){
            Debug.Log("MI");
            isGood3=true;
        }
        if(noteIndex == 3){
            Debug.Log("FA");
            isGood4=true;
        }
        ValidationNote();
    }
    void ValidationNote(){
        if(isGood1 == true){
            if(isGood2 == true){
                if(isGood3 == true){
                    if(isGood4 == true){
                        _briquet.SetActive(true);
                        _lumierePuzzle.AllumerLight(5);
                    }
                }else if(isGood4 == true){
                    _audio.PlayOneShot(_note[7]);
                    isGood1=false;
                    isGood2=false;
                    isGood3=false;
                    isGood4=false;
                }
            }else if(isGood4 == true || isGood3==true){
                isGood1=false;
                isGood2=false;
                isGood3=false;
                isGood4=false;
                _audio.PlayOneShot(_note[7]);
            }
        }else{
            isGood1=false;
            isGood2=false;
            isGood3=false;
            isGood4=false;
            _audio.PlayOneShot(_note[7]);
        }
    }

}
