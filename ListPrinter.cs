using System.Collections.Generic;
using UnityEngine;

public class ListPrinter : MonoBehaviour {

    [SerializeField]
    public List<int> numbers = new List<int>() {1, 1, 1, 1};
    private int number;
    private int index;
    private float currentTime = 0;
    private float waitingTime = 5f;
	
    // Update is called once per frame
    void Update ()
    {
        currentTime += Time.deltaTime;
        if (currentTime > waitingTime)
           {
               Print();
           }
	}

    void Print()
    {
        index = Random.Range(0, numbers.Count-1);
        Debug.Log(numbers[index]);
        currentTime = 0;
    }
}
