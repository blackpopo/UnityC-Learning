using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guiSlider : MonoBehaviour
{
    public Text text;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSliderChanged()
    {
        text.text = "Slider value is " + slider.value;
    }
}
