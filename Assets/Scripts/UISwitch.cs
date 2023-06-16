using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISwitch : MonoBehaviour
{

    public GameObject start_game, play_human, play_plants, back, options, quit;

    public void OnPlay() 
    {
        start_game.SetActive(false);
        options.SetActive(false);
        quit.SetActive(false);
        play_human.SetActive(true);
        play_plants.SetActive(true);
        back.SetActive(true);
    }


    public void OnBack()
    {
        start_game.SetActive(true);
        options.SetActive(true);
        quit.SetActive(true);
        play_human.SetActive(false);
        play_plants.SetActive(false);
        back.SetActive(false);
    }


    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
