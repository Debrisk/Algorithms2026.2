
using System;
using UnityEngine;



public class BubbleSort : MonoBehaviour
{
    [ContextMenu("Sort")]

    void Start()
    {
        int[] numbers = new int[20];
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = UnityEngine.Random.Range(0, 200);
        }
        PrintArray(numbers, numbers.Length);
        Sort(numbers, numbers.Length);
        PrintArray(numbers, numbers.Length);
    }
    public virtual void Sort(int[] numbers, int n)
    {
        int i, j;
        bool hasSwapped;
        for(i = 0; i < n - 1; i++)
        {
            hasSwapped = false;

            for(j = 0; j < n - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                    {
                    //Swap 
                    hasSwapped = true;

                    }
            }
            if (!hasSwapped)
            {
                break;
            }
        }


    }

    void PrintArray(int[] numbers, int size)
    {
        Debug.Log(numbers);
        for (int i = 0; i < size; i++)
        {
            Debug.Log(numbers[i] + " ");
        }
    }
    public void Swap(int[] numbers, int i, int j)
    {
        //Regular
        //{
        //    int temp = numbers[i];
        //    numbers[i] = numbers[j];
        //    numbers[j] = temp;

        //Xor operator
        //numbers[i] = numbers[i] ^ numbers[j];
        //numbers[j] = numbers[i] ^ numbers[j];
        //numbers[i] = numbers[i] ^ numbers[j];

        //Tuple
        (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
    }


}
