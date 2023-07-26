using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private string newgame;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    public void NewGame()
    {
        painelMenuInicial.SetActive(false);
        SceneManager.LoadScene(newgame);
    }

    public void Settings()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
        
    }

    public void closeSettings()
    {
        painelMenuInicial.SetActive(true);
        painelOpcoes.SetActive(false);
    }

    public void Exit()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
        
    }


}
