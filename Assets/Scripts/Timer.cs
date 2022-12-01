using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshPro _time;
    private int temps = 600;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Horloge");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Horloge(){
        while(true){
            yield return new WaitForSeconds(1f);
            temps = temps - 1;
            int min = temps/60;
            int seconde = temps - min*60;
            _time.text = min + ":" + seconde;
        }
    }
}
