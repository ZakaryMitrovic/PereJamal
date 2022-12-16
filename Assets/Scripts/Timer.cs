using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshPro _time;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioClip _sonMort;
    private int temps = 600;
    public GameObject fadeScreen;
    private float duration;
    private float duration2;

    // Start is called before the first frame update
    void Start()
    {
        duration2 = 1f;
        StartCoroutine("Intro");
        StartCoroutine("Horloge");
        fadeScreen.GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f, 1f);
    }

    IEnumerator Intro(){
        //ajout son ported

        yield return new WaitForSeconds(5f); //changer dependament de la longeur du son

        //fade in
        while(duration2 > 0f)
        {
            duration2 = duration2 - 0.01f;
            fadeScreen.GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f, duration2);
            yield return new WaitForSeconds(0.01f);
        }   
    }
    IEnumerator Horloge()
    {
        while(temps >= 0)
        {
            yield return new WaitForSeconds(1f);
            temps = temps - 1;
            int min = temps/60;
            int seconde = temps - min*60;
            _time.text = min + ":" + seconde.ToString("D2");
        }
        StartCoroutine("FadeOut");
    }

    IEnumerator FadeOut(){
        while(duration < 1f)
        {
            duration += 0.01f;
            fadeScreen.GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f, duration);
            yield return new WaitForSeconds(0.01f);
        }
        _audio.PlayOneShot(_sonMort);
        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("Mort");
    }
}
