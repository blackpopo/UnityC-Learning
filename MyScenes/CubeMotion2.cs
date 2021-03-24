using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMotion2 : MonoBehaviour
{
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Animator animatior = GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (flag)
            {
                animatior.CrossFade("MyAnime2", 2.0f);
            }
            else
            {
                animatior.CrossFade("MyAnime1", 2.0f);
            }

            flag = !flag;
        }
    }
}
  