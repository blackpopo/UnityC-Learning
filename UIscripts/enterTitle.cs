using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enterTitle : MonoBehaviour
{
    bool enter = false;
    bool flash = false;
    [SerializeField] Image image = null;

    public void EnterScene()
    {
        Debug.Log("Enter the Game!");
        if (!enter)
        {
            //Go to next scene
            enter = true;
            flash = true;
            Invoke("SceneChange", 3.0f);
        }
    }

    public void Update()
    {
        if (flash)
        {
            image.color = new Color(0.5f, 0.5f, 0f, 0.5f);
            image.color = new Color(0f, 0f, 0f, 0f);
        }
    }

    public void Start()
    {
        Debug.Log("This script is Alive");
        image.color = Color.clear;
    }

    void SceneChange()
    {
        SceneManager.LoadScene("LeaveScene");
    }
}
