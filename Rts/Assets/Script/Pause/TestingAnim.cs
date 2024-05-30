using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestingAnim : MonoBehaviour
{
    //Este c�digo va para DinamicPauseCanvas, para que pueda hacer la funci�n y le diga al objeto con el c�digo PauseGame que ya termin� la animaci�n.
    [SerializeField] private PauseGame gameUIref;

    //Una vez que termine la animaci�n se ejecuta la Funci�n AnimDone() en el PauseGame.
    public void AnimationDoDone()
    {
       // if(Opti)
        gameUIref.AnimDone();
    }

    public void AnimationPartOfMenuDone()
    {
        gameUIref.OptionShow();
    }

    //Termina la animaci�n de Opcion Cerrar nos regresamos a PauseGame
    public void AnimationOptionDone()
    {
        gameUIref.OptionDone();
    }
}