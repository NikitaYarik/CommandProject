using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraChangeScript : MonoBehaviour
{
    [SerializeField] private GameObject man;
    [SerializeField] private GameObject Poop;
    
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            man.SetActive(false);
            Poop.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            man.SetActive(true);
            Poop.SetActive(false);
        }
    }
}
