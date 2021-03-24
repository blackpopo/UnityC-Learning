using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] RectTransform _rectTransform;
    // Start is called before the first frame update

    public void MoveLocal()
    {
        _rectTransform.DOMoveX(-300f, 2.0f);
    }
    
}
