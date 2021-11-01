using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween {
    
    public Transform Target { get; private set; }
    public Vector3 StartPos { get; private set; }
    public Vector3 EndPos { get; private set; }
    public float StartTime { get; private set; }
    public float Duration { get; private set; }

    public Tween(Transform target, Vector3 startposition, Vector3 endposition, float time, float duration)
    {
        Target = target;
        StartPos = startposition;
        EndPos = endposition;
        StartTime = time;
        Duration = duration;
    }
}
