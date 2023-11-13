using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Transform Trans;
    private float ver;
    private float hor;
    public float speed;
    public Transform trans_b;
    void Start()
    {
        Trans = GetComponent<Transform>();
    }

    
    void Update()
    {
        //движение персонажа
        ver = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");
        Trans.position += Trans.forward * ver * speed * Time.deltaTime;
        Trans.position += Trans.right * hor * speed * Time.deltaTime;

        // поворот игрока
        if(hor < 0)
        {
            trans_b.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (hor > 0)
        {
            trans_b.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (ver < 0)
        {
            trans_b.localRotation = Quaternion.Euler(0, 270, 0);
        }
        else if (ver > 0)
        {
            trans_b.localRotation = Quaternion.Euler(0, 90, 0);
        }

    }
}
