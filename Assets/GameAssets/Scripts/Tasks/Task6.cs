using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Task6 : MonoBehaviour
{
    int contador = 0;
    public void complete() {
       
        contador++;

        if (contador >= 4)
        {
            FindObjectOfType<TaskManager>().FinishTask(true);

        }
    }

}