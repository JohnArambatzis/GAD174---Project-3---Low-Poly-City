using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxis
    {
        MouseH,
        MouseV
    }
    [Header("Rotation Variables")]
    public RotationAxis axis = RotationAxis.MouseH;
    [Range(0, 1000)]
    public float sensitivity = 100;
    public float minY = -90, maxY = 90;
    private float _rotY;

    private void Start()
    {
        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().freezeRotation = true;
        }
        if (GetComponent<Camera>())
        {
            axis = RotationAxis.MouseV;
        }
    }
    private void Update()
    {


        if (axis == RotationAxis.MouseH)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime, 0);
        }
        else // MouseV - x
        {
            _rotY += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
            _rotY = Mathf.Clamp(_rotY, minY, maxY);
            transform.localEulerAngles = new Vector3(-_rotY, 0, 0);
        }

    }
}
