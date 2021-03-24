using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class getToggleButton : MonoBehaviour
{
    public Toggle toggle;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Don't import UnityEngin.UI.Elements.Toggle

    public void OnToggleChanged()
    {
        Debug.Log(toggle.isOn);
        text.text = toggle.isOn ? "YOU ARE CRAZY!!!!!!": "Oh... Very SAD......";
    }

}
