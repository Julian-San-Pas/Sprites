using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections.Generic;

public class SimplAudio : MonoBehaviour
{ 
    [HeaderAttribute("Referencias")]

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Button nextAudio;

    [SerializeField] List<AudioClip> audioClips = new List<AudioClip>();

    [SerializeField] bool loopPlaylist = true;
    
    private int index = -1;

    private void Awake()
    {
        if (nextAudio != null)
        {
            nextAudio.onClick.AddListener(PlayNext);
        }
    }

    private void OnDestroy()
    {
        if (nextAudio != null)
        {
            nextAudio.onClick.RemoveListener(PlayNext);
        }
    }
    public void PlayNext()
    {
        if (audioClips.Count == 0 || audioSource == null || audioClips == null) return;
        index++;
        if (index >= audioClips.Count)
        {
            if (loopPlaylist)
            {
                index = 0;
            }
            else
            {
                index = audioClips.Count - 1;
                return; // No more clips to play
            }
        }
        audioSource.Stop();
        audioSource.clip = audioClips[index];
        audioSource.Play();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
