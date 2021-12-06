using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task2 : MonoBehaviour
{
    [SerializeField] Transform boton;
    Vector3 rotate = new Vector3(0.0f, 0.0f, 1.0f);
    bool pressed = false;
    public void press()
    {
        pressed = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pressed == true)
        {
            boton.Rotate(rotate * 30.0f * Time.deltaTime);
            if(boton.rotation.eulerAngles.z >= 90.0f)
            {
                boton.transform.eulerAngles = new Vector3(0,0,90);
                System.Threading.Thread.Sleep(500);
                FindObjectOfType<TaskManager>().FinishTask(true);
            }
        }
    }
}
