using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPRY : MonoBehaviour
{
    public int x;       //roll
    public int y;       //yaw
    public int z;       //pitch

    float maxAngleRotatePerFrame;

    public void Start()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    public void Update()
    {
        tiltTranslation(x, y, z);
    }

    public void tiltTranslation(int x, int y, int z)
    {
        // Figure out how we want to rotate and how much that is
        Quaternion curRot = transform.rotation;
        Quaternion goalRot = Quaternion.Euler(
                x,
                y,
                z
                );
        float angleToTurn = Quaternion.Angle(curRot, goalRot);


        transform.rotation = Quaternion.RotateTowards(curRot, goalRot, angleToTurn);

    }

}
