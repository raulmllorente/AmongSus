using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task3 : MonoBehaviour
{
    [SerializeField] Slider sliderOG;
    [SerializeField] Slider sliderSol;
    bool moving = true;

    public void move()
    {
        moving = true;
    }

    public void notmove()
    {
        moving = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        sliderOG.value = Random.Range(10, 90);
    }

    // Update is called once per frame
    void Update()
    {
        if(sliderSol.value >= sliderOG.value-10 && sliderSol.value <= sliderOG.value + 10 && moving == false)
        {
            FindObjectOfType<TaskManager>().FinishTask(true);
        }
    }
}
