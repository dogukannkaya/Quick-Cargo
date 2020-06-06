using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class ScreenManagement : MonoBehaviour
{
    public AdManager admanager;

    private void Start()
    {
        admanager.PlayInterstitialAd();
    }

    public void Retry()
    {
        score.scoreValue = 0;
        AudioListener.volume = 1;
        GameObject.FindGameObjectWithTag("audiomanager").GetComponent<AudioManager>().Stop("Music");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        score.scoreValue = 0;
        AudioListener.volume = 1;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
