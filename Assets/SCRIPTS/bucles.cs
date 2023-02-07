using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucles : MonoBehaviour
{
    private int a; 
    void Start()
    {
        while(a <= 10)
        {
            Debug.Log($"10 x {a} = {10 * a}");
            a++;
        }
    }

    
}
