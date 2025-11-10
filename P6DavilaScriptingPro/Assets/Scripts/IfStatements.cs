using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        coffeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()

    {
        if (coffeTemperature > hotLimitTemperature)
        {
            print("Coffe is to hot.");

        }
        else if (coffeTemperature < coldLimitTemperature)
        {

            print("Coffe is to cold.");

        }
        else
        {
            print("Coffee is just right.");
        }
    }
}
