using System.Collections.Generic;
using UnityEngine;

public class ListPrinter : MonoBehaviour {

    [SerializeField]
    private List<int> numbers = new List<int>() {1, 1, 1, 1};
    private int number;
    private int index;
    private float currentTime = 0;
    private float waitingTime = 5f;
    private int previousNumber;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentTime += Time.deltaTime;
        if (currentTime > waitingTime)
        {
            previousNumber = numbers[numbers.Count-1];
            Print();
        }
	}

    void Print()
    {
        do
        {
            previousNumber = numbers[index];
            index = Random.Range(0, numbers.Count);
        }
        while (previousNumber == numbers[index]);
        Debug.Log(numbers[index]);
        currentTime = 0;
    }
}
