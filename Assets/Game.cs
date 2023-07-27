using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string menu;
    [SerializeField] private GameObject paginicial;
    [SerializeField] private GameObject pagpause;
    [SerializeField] private GameObject pagoptions;
    public void pausar()
    {
        paginicial.SetActive(false);
        pagpause.SetActive(true);
        pagoptions.SetActive(false);

    }

    public void resume()
    {
        paginicial.SetActive(true);
        pagpause.SetActive(false);
        pagoptions.SetActive(false);

    }

    public void abriroptions()
    {
        paginicial.SetActive(false);
        pagpause.SetActive(false);
        pagoptions.SetActive(true);


    }

    public void fecharoptions()
    {
        paginicial.SetActive(false);
        pagpause.SetActive(true);
        pagoptions.SetActive(false);
    }

    public void exit()
    {
        SceneManager.LoadScene(menu);
    }

}

