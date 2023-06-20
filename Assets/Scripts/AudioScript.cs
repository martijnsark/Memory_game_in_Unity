using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    public AudioSource buttonSound;
    
    public void ButtonSFX()
    {
        buttonSound.Play();
    }
}
