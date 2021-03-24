using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TransparentBackground : MonoBehaviour
{
    [SerializeField] RawImage BGImage;

    [SerializeField] RawImage FGImage;

    [SerializeField] TMP_Text log;
    WebCamTexture frontCamTexture;
    WebCamTexture rearCamTexture;
    

    public Color32[] color32;
    float intervalTimer = 10.0f;
    float interval = 0.0f;
    WebCamDevice[] _devices;
    
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        _devices = WebCamTexture.devices;

        for (int i = 0; i < _devices.Length; i++)
        {
            Debug.Log("Devices name: [" + i + "]  is " + _devices[i]);
        }
        frontCamTexture = new WebCamTexture(_devices[0].name);
        rearCamTexture = new WebCamTexture(_devices[1].name);
        FrontTaker();
        RearTaker();

    }

    // Update is called once per frame
    void Update()
    {
        interval += Time.deltaTime;
        if (interval > intervalTimer)
        {
            interval = 0.0f;
            FrontTaker();
            RearTaker();
        }
    }

    void FrontTaker()
    {
        if (rearCamTexture.isPlaying)
        {
            color32 = frontCamTexture.GetPixels32();
            //背面画面の貼り付け
            Texture2D _reartexture = new Texture2D(rearCamTexture.height, rearCamTexture.width);
            BGImage.texture = _reartexture;
            _reartexture.SetPixels32(color32);
            _reartexture.Apply();
            rearCamTexture.Stop();
            
        }
        FGImage.texture = rearCamTexture;
        Debug.Log("Front Information : " + _devices[0].availableResolutions);
        Debug.Log(" Is Front or Rear? " + _devices[0].isFrontFacing);
        frontCamTexture.Play();
        color32 = frontCamTexture.GetPixels32();
        //フロント画面の貼り付け
        Texture2D texture = new Texture2D(frontCamTexture.height, frontCamTexture.width);
        FGImage.texture = texture;
        texture.SetPixels32(color32);
        texture.Apply();
    }

    void RearTaker()
    {
        log.text += "\n撮影日時 : " + Time.realtimeSinceStartup;
        if (frontCamTexture.isPlaying)
        {
            frontCamTexture.Stop();
        }
        Debug.Log("Rear Information : " + _devices[1].availableResolutions);
        Debug.Log(" Is Front or Rear? " + _devices[1].isFrontFacing);
        frontCamTexture.Play();
    }
}
