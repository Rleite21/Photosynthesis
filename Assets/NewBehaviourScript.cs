using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    public void NewGame()
    {

    }

    public void LoadGame()
    {

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
