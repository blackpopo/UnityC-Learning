using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] TMP_Dropdown _dropdown;

    GameObject options;
    GameObject option;
    public void Start()
    {
        options = GameObject.FindWithTag("option");
        Debug.Log(options);
        option = GameObject.FindWithTag("options");
        Debug.Log(option.GetComponents<ScriptableObject>());
    }

    public void OnClick()
    {
        switch (_dropdown.value)
        {
            case 0:
                break;
            case 1:
                break;
            default:
                break;
        }
    }
}
