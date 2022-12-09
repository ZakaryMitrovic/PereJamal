using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTable : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {
        _audio.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JouerAudio(){
        _audio.enabled = true;
    }
}
