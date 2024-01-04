using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// add by ChhenG
public class BladeRotation : MonoBehaviour
{
    public Vector3 rotation;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotation * 1 * Time.deltaTime);
    }
}
