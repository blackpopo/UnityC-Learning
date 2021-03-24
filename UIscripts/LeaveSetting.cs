using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class LeaveSetting : MonoBehaviour
{
    [SerializeField] Toggle toggle = null;
    [SerializeField] GameObject leavePanel = null;
    [SerializeField] Text text = null;
    Animator anime;
    public void Start()
    {
        Debug.Log("start is ok...");
        leavePanel.SetActive(false);
        Debug.Log(leavePanel.activeSelf);
        anime = GetComponent<Animator>();
    }

    public void CheckIsOn()
    {
        if (toggle.isOn)
        {
            text.text = "本当にやめちゃうの？";
            anime.SetBool("cansel_flag", false);
            Debug.Log("toggle is on");
            Debug.Log(leavePanel.activeSelf);
            anime.SetBool("setting_appear", true);
        }
        else
        {
            Debug.Log("toggle is off");
            anime.SetBool("cansel_flag", true);
            Debug.Log(leavePanel.activeSelf);
            text.text = "ありがとう！";
            anime.SetBool("setting_appear", false);
        }
    }
}
