using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 30;
    public int addedAge = 1;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
    }

    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
    {
        Debug.Log(30 + 1);

        Debug.Log(currentAge + 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
 

}
