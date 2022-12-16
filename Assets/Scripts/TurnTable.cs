using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTable : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    [SerializeField] private GameObject _disque;

    // Start is called before the first frame update
    void Start()
    {
        _audio.enabled = false;
    }

    public void JouerAudio(){
        _audio.enabled = true;
        StartCoroutine(Tourner());
    }

    private IEnumerator Tourner(){
        while(true){
            _disque.transform.Rotate(0,0,1f);
            yield return new WaitForSeconds(0.005f);
        }
    }
}
