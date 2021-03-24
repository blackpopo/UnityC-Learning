using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FACEScrollView : MonoBehaviour
{
    public Sprite[] splites;
    Image image;

    void Start()
    {
        image = GameObject.Find("Image").GetComponent<Image>();
        image.sprite = splites[0];
    }

    public void ButtonClick(int number)
    {
        if (0 <= number && number < splites.Length)
        {
            image.sprite = splites[number];
        }
        else
        {
            image.sprite = splites[0];
        }

    }

}
