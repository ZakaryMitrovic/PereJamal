using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nametag : MonoBehaviour
{
    [SerializeField] private GameObject key;
    [SerializeField] private LumierePuzzle lumierePuzzle;
    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nameTag(){
        Debug.Log("Works");
        key.SetActive(true);
        lumierePuzzle.AllumerLight(6);
    }

    public void AllumerLumiereFinale()
    {
        lumierePuzzle.AllumerLight(7);
    }
}
