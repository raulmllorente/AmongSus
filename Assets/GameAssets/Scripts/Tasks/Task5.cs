using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task5 : MonoBehaviour
{

    [SerializeField] Text percentageText;
    [SerializeField] Slider slider;
    bool moving = true;


    public void move()
    {
        moving = true;

    }

    public void notmove()
    {
        moving = false;
    }

    public void Update()
    {
        percentageText.text = Mathf.RoundToInt(slider.value * 100) + "%";

        if (slider.value == 1 && moving == false)
        {
            FindObjectOfType<TaskManager>().FinishTask(true);

        }
    }


}
