using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task1 : MonoBehaviour
{
    [SerializeField] Text textCode;
    [SerializeField] Text textCodeSolution;
    int[] numbers = new int[4];
    int[] solution = new int[4];
    int code;
    int codeSolution;
    int order;

    void Start()
    {
        generateCode();
    }

    public void setCode(int number)
    {
        solution[order] = number;
        codeSolution = solution[0] + solution[1] * 10 + solution[2] * 100 + solution[3] * 1000;
        if (codeSolution < 10)
        {
            textCodeSolution.text = "000" + codeSolution.ToString();
        }
        else if (codeSolution < 100)
        {
            textCodeSolution.text = "00" + codeSolution.ToString();
        }
        else if (codeSolution < 1000)
        {
            textCodeSolution.text = "0" + codeSolution.ToString();
        }
        else
        {
            textCodeSolution.text = codeSolution.ToString();
        }

        order++;
        if (order == 4)
        {
            for (int i = 0; i < 4; i++)
            {
                if (numbers[i] != solution[i])
                {
                    generateCode();
                    break;
                }
                if (i == 3)
                {
                    FindObjectOfType<TaskManager>().FinishTask(true);
                    generateCode();
                }
            }
        }

    }

    void generateCode()
    {
        order = 0;
        numbers[0] = Random.Range(1, 9);
        numbers[1] = Random.Range(1, 9);
        numbers[2] = Random.Range(1, 9);
        numbers[3] = Random.Range(1, 9);
        solution[0] = 0;
        solution[1] = 0;
        solution[2] = 0;
        solution[3] = 0;
        code = numbers[0] + numbers[1] * 10 + numbers[2] * 100 + numbers[3] * 1000;
        textCode.text = code.ToString();
        textCodeSolution.text = "0000";
    }
}
