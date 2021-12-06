using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task4 : MonoBehaviour
{
    // Start is called before the first frame update
    public void complete()
    {
        FindObjectOfType<TaskManager>().FinishTask(true);
 
    }
}
