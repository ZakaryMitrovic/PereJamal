using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    [SerializeField] private GameObject _fire;
    [SerializeField] private Material _waxAllumer;
    [SerializeField] private LumierePuzzle _light;
    [SerializeField] private Plates _plates;
    [SerializeField] private AudioClip sonFeu;
    [SerializeField] private AudioSource _audio;
    public bool allumer = false;
    [SerializeField] private bool _alreadyLight;

    [SerializeField] private Candles _candles;

    private void Start()
    {
        if(_alreadyLight) {
            Allumer();
        }
    }

    private void Allumer()
    {
        _fire.SetActive(true);
        Material[] mats = GetComponent<MeshRenderer>().materials;
        mats[0] = _waxAllumer;
        GetComponent<MeshRenderer>().materials = mats;

        _audio = GetComponent<AudioSource>();
        _audio.PlayOneShot(sonFeu);

        allumer = true;

        FinirPuzzle();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fire"))
        {
            Allumer();
        }
    }

    private void FinirPuzzle()
    {
        if(_candles.SiChandelsAllumer())
        {
            _light.AllumerLight(2);
            _plates.isAtPuzzle3 = true;
        }
    }


}

