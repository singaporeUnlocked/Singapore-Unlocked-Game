using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate_Move_Controller : MonoBehaviour
{
    [SerializeField]
    //Initialize movement variables from gyroscope

    ///<summary>
    ///Variables for Gyro-Accelerator Module
    ///Gx = Gyro X-axis data in degree/seconds
    ///Gy = Gyro Y-axis data in degree/seconds
    ///Gz = Gyro Z-axis data in degree/seconds
    ///Ax = Accelerometer X-axis data in g
    ///Ay = Accelerometer Y-axis data in g
    ///Az = Accelerometer Z-axis data in g
    ///</summary>
    ///

    float gx, gy, gz, ax, ay, az;

    float de_gx, de_gy, de_gz, de_ax, de_ay, de_az;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // default position | rotation
        de_gx = 0;
        de_gy = 0;
        de_gz = 0;
        de_ax = 0;
        de_ay = 0;
        de_az = 0;

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        PositionalTranslation(ax, ay, az);
        TiltTranslation(gx, gy, gz);
    }

    public void PositionalTranslation(float AX, float AY, float AZ)
    {
        rb.velocity = new Vector3(AX - gameObject.transform.position.x, AY - gameObject.transform.position.y, AZ - gameObject.transform.position.z);


    }

    public void TiltTranslation(float GX, float GY, float GZ)
    {
        rb.angularVelocity = new Vector3(Mathf.Round(GX*Mathf.Deg2Rad*10)/10, Mathf.Round(GY * Mathf.Deg2Rad * 10) / 10, Mathf.Round(GZ * Mathf.Deg2Rad * 10) / 10);

    }
}
