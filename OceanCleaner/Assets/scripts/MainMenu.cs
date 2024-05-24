using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    [SerializeField] public GameObject Canva;

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Canva.SetActive(true);

    }
    public void QuitGame()
    {
        Application.Quit();
            
    }


}
