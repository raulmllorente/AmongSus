using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TaskType { downloadData, inputCode, energy, fusible, sus, oxigenlevel, cleargarbaje }

public class TaskManager : MonoBehaviour
{
    [SerializeField]
    GameObject interactPanel;

    public List<GameObject> tasks = new List<GameObject>();

    TaskInteract actualTask;


    public void ShowInteractPanel(bool value)
    {
        interactPanel.SetActive(value);
    }

    public void DoTask(TaskInteract theTask)
    {
        tasks[(int)theTask.type].SetActive(true);
        actualTask = theTask;
    }

    public void FinishTask(bool value)
    {
        if (actualTask != null)
        {
            tasks[(int)actualTask.type].SetActive(false);
            actualTask.isDone = value;
            actualTask = null;
        }
    }

}