using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
    [SerializeField] private GameObject _statue1;
    [SerializeField] private GameObject _statue2;
    [SerializeField] private GameObject _statue3;
    [SerializeField] private GameObject _statue4;

    bool isGood;
    // Start is called before the first frame update
    void Start()
    {
        isGood = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckStatues();
    }

    void CheckStatues(){
        if (_statue1.transform.rotation.z >= 0.6 && _statue1.transform.rotation.z <= 0.8){
            isGood = true;
            Debug.Log(isGood);
        }else{
            isGood = false;
            Debug.Log(isGood);
        }
    }
}
