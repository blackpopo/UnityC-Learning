using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaveScene : MonoBehaviour
{
    public Canvas popup;

    public Toggle toggle;

    public void Start()
    {
        popup.enabled = false;
    }

    public void checkOnClick()
    {
        if (toggle.isOn)
        {
            popup.enabled = true;
        }
    }
}
