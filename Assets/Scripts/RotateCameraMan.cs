using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float sens;
    public Transform trans;
    public float mouseX;
    public float mouseY;
    void Start()
    {
        trans = GetComponent<Transform>();

    }


    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        mouseY += Input.GetAxis("Mouse Y") * sens * Time.deltaTime;
        mouseY = Mathf.Clamp(mouseY, -10, 65);
        trans.localRotation = Quaternion.Euler(mouseY, mouseX, 0);
    }
}
