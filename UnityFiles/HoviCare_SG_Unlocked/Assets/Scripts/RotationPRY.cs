using UnityEngine;

public class RotationPRY : MonoBehaviour
{
    public int x;       //roll
    public int y;       //yaw
    public int z;       //pitch
    public string[] dataSplit;
    public string data = "";

    float maxAngleRotatePerFrame;


    public void Start()
    {
        x = 0;
        y = 0;
        z = 0;
        dataSplit = new string[4];
    }

    public void Update()
    {
        data = GameObject.Find("SerialController").GetComponent<SerialController>().ReadSerialMessage();
        Debug.Log(data);

        if (data == null)
            return;



        dataSplit = data.Split(',');
        if (dataSplit.Length > 0)
        {
            tiltTranslation(float.Parse(dataSplit[2]), float.Parse(dataSplit[0]), float.Parse(dataSplit[1]));
        }
    }

    public void tiltTranslation(float x, float y, float z)
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
