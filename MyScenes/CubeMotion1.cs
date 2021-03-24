using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMotion1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AnimationClip clipA = new AnimationClip();
        clipA.legacy = true;
        AnimationCurve curve = AnimationCurve.EaseInOut(0f, 3f, 3f, 3f);
        Keyframe keyA1 = new Keyframe(1.0f, 7.0f);
        Keyframe keyA2 = new Keyframe(2.0f, -7.0f);
        curve.AddKey(keyA1);
        curve.AddKey(keyA2);
        clipA.SetCurve("", typeof(Transform), "localPosition.z", curve);
        clipA.wrapMode = WrapMode.Loop;
        Animation animation = GetComponent<Animation>();
        animation.AddClip(clipA, "animeA");
        //animation.Play("clipA");
        
        AnimationClip clipB = new AnimationClip();
        clipB.legacy = true;
        AnimationCurve curveB1 = AnimationCurve.EaseInOut(0f, 3f, 4f, 3f);
        AnimationCurve curveB2 = AnimationCurve.EaseInOut(0f, 3f, 4f, 3f);
        Keyframe keyB1 = new Keyframe(1f, -7f);
        Keyframe keyB2 = new Keyframe(3f, 7f);
        Keyframe keyB3 = new Keyframe(1f, 7f);
        Keyframe keyB4 = new Keyframe(3f, -7f);
        curveB1.AddKey(keyB1);
        curveB1.AddKey(keyB2);
        curveB2.AddKey(keyB3);
        curveB2.AddKey(keyB4);
        clipB.SetCurve("", typeof(Transform), "localScale.x", curveB1);
        clipB.SetCurve("", typeof(Transform), "localScale.y", curveB2);
        clipB.wrapMode = WrapMode.Loop;
        animation.AddClip(clipB, "animeB");
        animation.Play("animeA");

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1.0f, 2.0f, 3.0f);
        Animation animation = GetComponent<Animation>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (animation.IsPlaying("animeA"))
            {
                // animation.PlayQueued("clipB", QueueMode.PlayNow);
                animation.CrossFade("animeB", 3.0f);
                Debug.Log("ToAnimeB");
            }
            else
            {
                // animation.PlayQueued("clipA", QueueMode.CompleteOthers);
                animation.CrossFade("animeA", 3.0f);
                Debug.Log("ToAnimeA");
            }
        }
    }
}