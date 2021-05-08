using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Toggle))]
public class ToggleSound : MonoBehaviour, IPointerClickHandler
{

    public AudioClip sound;
    private Toggle tgl { get { return GetComponent<Toggle>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
    }

    void playSound()
    {
        source.PlayOneShot(sound);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        playSound();
    }
}
