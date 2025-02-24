using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject gameOverControllerOwner;
    public MenuOver gameOverController; // Refer�ncia ao controlador de Game Over
    [SerializeField] private GameObject CanvaOver;
    private void Start()
    {
        gameOverController = GetComponent<MenuOver>();
    }
    void OnTriggerEnter(Collider other)
    {
        // Verifica se o player colidiu com um objeto com a tag "Player"
        if (other.CompareTag("barco"))
        {
            CanvaOver.SetActive(true);
            // Chama a fun��o para exibir a tela de Game Over
            //gameOverController.ShowGameOverScreen();
        }
    }
}
