using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public Transform Car;
    public Vector3 CameraDistant;

    public float SmoothSpeed = 0.125f;

    void Start()
    {
        CameraDistant = transform.position - Target.transform.position;
    }

    void CameraPose()
    {
        transform.position =
            Vector3
                .Lerp(transform.position,
                (Target.position),
                Time.deltaTime *6f);
        if (GameManager._gamemanager.isGameStart)
        {
            // Target.transform.position=new Vector3(transform.position.x,transform.position.y,Car.transform.position.z-1.2f);
        }
    }

    private void Update()
    {
        CameraPose();
    }
}
