using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nametag : MonoBehaviour
{
    [SerializeField] private GameObject[] socket;
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

    void OnTriggerEnter(Collider other){

        if(socket[0] == other.CompareTag("J")){
            Debug.Log("J");
        }
        if(socket[1] == other.CompareTag("M")){
            Debug.Log("J");
        }
        if(socket[2] == other.CompareTag("O")){
            Debug.Log("O");
        }
        if(socket[3] == other.CompareTag("Z")){
            Debug.Log("Z");
        }
    }
    public void AllumerLumiereFinale()
    {
        lumierePuzzle.AllumerLight(7);
    }
}
