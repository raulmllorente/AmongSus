using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerInteract : MonoBehaviour
{
    TaskInteract task;

    TaskManager taskM;

    private void Start()
    {
        taskM = FindObjectOfType<TaskManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        var nearbyTask = other.GetComponent<TaskInteract>();
        if (nearbyTask)
        {
            if (nearbyTask.isDone == false)
            {
                task = nearbyTask;
                taskM.ShowInteractPanel(true);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (task != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                taskM.DoTask(task);
                taskM.ShowInteractPanel(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var nearbyTask = other.GetComponent<TaskInteract>();
        if (nearbyTask)
        {
            if (nearbyTask.isDone == true)
            {
                task = null;
                taskM.ShowInteractPanel(false);
            }
        }
    }

}
