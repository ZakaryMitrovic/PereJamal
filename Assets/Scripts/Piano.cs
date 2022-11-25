using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    [SerializeField] Animator _anim;
    [SerializeField] GameObject _briquet;
    [SerializeField] AudioClip[] _note;
    [SerializeField] AudioSource _audio;

    string[] notes = {"Do", "Re", "Mi", "Fa", "Sol", "La", "Si"};

    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        _anim.GetComponent<Animator>();
        _briquet.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JouerNote(int noteIndex){
        _anim.SetTrigger(notes[noteIndex]);
        _briquet.SetActive(true);
        _audio.PlayOneShot(_note[noteIndex]);
    }

}
