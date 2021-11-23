using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkOutOfBounds : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        checkDelete();
    }
    void checkDelete()
    {
        if (!gameObject.GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
    }
}
