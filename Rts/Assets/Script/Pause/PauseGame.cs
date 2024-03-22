using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject _canvasPause;
    [SerializeField] private GameObject _canvasGame;
    //[SerializeField] private AudioSource _audioGame; //esto es para pausar el audio del juego
    //[SerializeField] private AudioSource _audioPause; //esto es para poner la m�sica de pausa.

    //Aqu� se pone pausa a la m�sica del juego, se pone play a la m�sica de pausa y se pone el canvas
    public void Pause()
    {
       // _audioGame.Pause();
       //_audioPause.Play(); 
        _canvasPause.SetActive(true);
        _canvasGame.SetActive(false);
        Time.timeScale = 0.0f;

    }

    //Aqu� se resume el juego y se desactiva el canvas
    public void Resume()
    {
        //_audioGame.Play();
        //audioPause.Pause();
        _canvasPause.SetActive(false);
        _canvasGame.SetActive(true);
        Time.timeScale = 1.0f;
    }

    public void ExitGame()
    {

    }


}
