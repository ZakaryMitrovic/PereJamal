using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshPro _time;
    private int temps = 6;
    private bool _isFading;
    public GameObject fadeScreen;
    private float duration;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Horloge");
        fadeScreen.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0f);
    }
    
    IEnumerator Horloge()
    {
        while(temps >= 0)
        {
            yield return new WaitForSeconds(1f);
            temps = temps - 1;
            int min = temps/60;
            int seconde = temps - min*60;
            _time.text = min + ":" + seconde;
        }




        while(duration < 1f)
        {
            duration += 0.01f;
            fadeScreen.GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f, duration);
            yield return new WaitForSeconds(0.01f);
        }           
            yield return new WaitForSeconds(1);

            SceneManager.LoadScene("Mort");
    }
}
