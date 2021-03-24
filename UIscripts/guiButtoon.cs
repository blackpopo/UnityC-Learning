using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guiButtoon : MonoBehaviour
{
    public Canvas setting;

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        setting.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (setting.enabled)
            {
                setting.enabled = false;
                text.text = "Setting is OFF";
            }
            else
            {
                setting.enabled = true;
                text.text = "Setting is ON";
            }

        }
        
    }

    public void OnButtonPressed()
    {
        text.text = "OKEEEEEEEEEEEE!!";
    }
}
