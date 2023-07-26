using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneycount : MonoBehaviour
{
    // Start is called before the first frame update
    public int count;
    public Text text;
    void Start()
    {
        count = PlayerPrefs.GetInt("amount");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire!"))
        {
            count += 1;
            PlayerPrefs.SetInt("amount", count);
        }

        text.text = "" + count;


    }
}
