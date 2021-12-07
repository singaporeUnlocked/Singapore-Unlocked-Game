using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float playSpeed;
    public GameObject floor;
    public ReceiveIMUValues controllerValues;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(controllerValues.x,0, playSpeed);
        //floor.GetComponent<Transform>().localScale = new Vector3(floor.transform.localScale.x, floor.transform.localScale.y, floor.transform.localScale.z + playSpeed * 3 * Time.deltaTime);
    }
}
