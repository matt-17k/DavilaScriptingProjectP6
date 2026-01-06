using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples = 17;
    public int bananas;

    private int stapler;
    private int sellotape;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FruitMachine(int a,int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total;" + answer);
    }


    private void Officesort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total:" + answer);
    }
}
