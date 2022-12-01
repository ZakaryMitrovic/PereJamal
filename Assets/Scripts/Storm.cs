using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storm : MonoBehaviour
{
    [SerializeField] private Light lightningLight;
    [SerializeField] private Light ambiantLight; 

    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioClip[] _audioClips;

    void Start()
    {
        StartCoroutine(CreatingRandomLightning());
    }

    private IEnumerator CreatingRandomLightning()
    {
        while(true)
        {
            float time = Random.Range(15f, 35f);
            yield return new WaitForSeconds(time);
            lightningLight.intensity = 1f;
            int indexClip = Random.Range(0, _audioClips.Length);
            Debug.Log(indexClip);
            _audio.PlayOneShot(_audioClips[indexClip]);
            while(lightningLight.intensity < 100f)
            {
                lightningLight.intensity *= 1.5f;
                yield return new WaitForSeconds(0.01f);
                ambiantLight.gameObject.SetActive(true);
            }
            yield return new WaitForSeconds(0.5f);
            while(lightningLight.intensity >= 0.1f)
            {
                lightningLight.intensity -= 5f;
                yield return new WaitForSeconds(0.01f);
                ambiantLight.gameObject.SetActive(false);
            }
        }
    }
}
