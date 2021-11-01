using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    public Tween tween;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector3.Distance(tween.Target.position, tween.EndPos);

        if (distance > 0.1f)
        {
            float timeFraction = (Time.time - tween.StartTime) / tween.Duration;
            timeFraction = timeFraction * timeFraction * timeFraction;
            tween.Target.position = Vector3.Lerp(tween.StartPos, tween.EndPos, timeFraction);
        }

        else
        {
            tween.Target.position = tween.EndPos;
            tween = null;
        }
    }

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (tween == null)
        {
            tween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }

        
}

       
 
    
