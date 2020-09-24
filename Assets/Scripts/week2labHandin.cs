using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class week2labHandin : MonoBehaviour
{
    float ovenTemp = 10.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    float maxLimitTemperature = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
        ovenTemp += Time.deltaTime * 5f;
        if (ovenTemp > maxLimitTemperature)
        {
            ovenTemp = maxLimitTemperature;
        }
    }
    void TemperatureTest()
    {
        // is the oven hotter than the good temp?
        if (ovenTemp > hotLimitTemperature)
        {
            // ... do this.
            if (ovenTemp >= maxLimitTemperature)
            {
                // oven reached it's max temp    
                print("max temp reached and it is not very good for the oven");
            }
            else
            {

                print("Oven is too hot");
            }

        }
        // also check if oven is colder than the good temp
        else if (ovenTemp < coldLimitTemperature)
        {
            // ... do this.
            print("Oven is too cold");
        }
        // If it is neither of those then...
        // It is at a good temp
        else
        {
            // ... do this.
            print("Oven is at the correct temperature");
        }
    }
}
