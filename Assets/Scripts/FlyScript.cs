using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    private float height;

    // Update is called once per frame
    void Update()
    {
        var y = Mathf.Sin(Time.time)*height;
        y = Mathf.Abs(y);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        Debug.Log("a");
    }
}
