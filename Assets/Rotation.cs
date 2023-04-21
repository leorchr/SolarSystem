using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationAngle = 0.1f;
    public float rotation = 0.1f;

    [SerializeField] private GameObject moon;
    void Update()
    {
        Vector3 earthUp = transform.up;
        Quaternion rotationMoon = new Quaternion(Mathf.Sin(rotationAngle * Time.deltaTime / 2) * earthUp.x,
                                                 Mathf.Sin(rotationAngle * Time.deltaTime / 2) * earthUp.y,
                                                 Mathf.Sin(rotationAngle * Time.deltaTime / 2) * earthUp.z,
                                                 Mathf.Cos(rotationAngle * Time.deltaTime / 2));

        moon.transform.rotation *= rotationMoon;


        transform.position = new Vector3(transform.position.x * Mathf.Cos(rotation * Time.deltaTime) + transform.position.z * Mathf.Sin(rotation * Time.deltaTime),
                                              transform.position.y,
                                              -transform.position.x * Mathf.Sin(rotation * Time.deltaTime) + transform.position.z * Mathf.Cos(rotation * Time.deltaTime));

        Quaternion rotationEarth = new Quaternion(Mathf.Sin(rotationAngle * Time.deltaTime / 2) * 1,
                                                 Mathf.Sin(rotationAngle * Time.deltaTime / 2) * 1,
                                                 Mathf.Sin(rotationAngle * Time.deltaTime / 2) * 1,
                                                 Mathf.Cos(rotationAngle * Time.deltaTime / 2));

        transform.rotation *= rotationEarth;

    }
}
