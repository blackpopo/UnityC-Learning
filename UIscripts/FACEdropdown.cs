using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FACEdropdown : MonoBehaviour
{
    public Sprite face1;
    public Sprite face2;
    public Sprite face3;
    public Sprite face4;
    public Image image;

    void Start()
    {
        image.sprite = face1;
    }

    public void selectedItemInDropdown(Dropdown item)
    {
        switch (item.value)
        {
            case 0:
                image.sprite = face1;
                break;
            case 1:
                image.sprite = face2;
                break;
            case 2:
                image.sprite = face3;
                break;
            case 3:
                image.sprite = face4;
                break;
            default:
                break;
        }
    }
}
