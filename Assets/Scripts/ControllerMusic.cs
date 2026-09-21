using System;
using UnityEngine;

public class ControllerMusic : MonoBehaviour
{
    [SerializeField] private AudioSource audioSourceGame;
    [SerializeField] private AudioSource audioSourcePause;
    [SerializeField] private AudioClip audioGame;
    [SerializeField] private AudioClip audioPause;

    public void ActiveMusicGameplay()
    {
        audioSourceGame.clip = audioGame;
        audioSourceGame.Play();
    }
    public void ActiveMusicMenuPause()
    {
        audioSourcePause.clip = audioPause;
        audioSourcePause.Play();
    }
    public void PauseMusicGameplay()
    {
        audioSourceGame.Pause();
    }

    public void StopMusicMenuPause()
    {
        audioSourcePause.Stop();
    }
}
