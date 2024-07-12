using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCoding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region
        //int number1 = 50;
        //int number2 = 20;
        //int result;

        //result = AddInteger(number1, number2);
        //print(result);

        //result = SubtractInteger(number1, number2);
        //print(result);

        //result = MultiplyInteger(number1, number2);
        //print(result);

        //result = DivideInteger(number1, number2); 
        //print(result);
        #endregion
        for(int i =1; i<10; i++)
        {
            print("7 * " + i + " = " + 7 * i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int AddInteger(int num1, int num2)
    {
        return num1 + num2;
    }

    int SubtractInteger(int num1, int num2)
    {
        return (num1 - num2);
    }

    int MultiplyInteger(int num1, int num2)
    {
        return num1 * num2;
    }

    int DivideInteger(int num1, int num2)
    {
        return num1 / num2;
    }
}
