using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{
    public KeyCode input;
    public float springPower;

    private HingeJoint hinge;


    // Start is called before the first frame update
    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
          JointSpring jointSpring = hinge.spring;

       if (Input.GetKey(input))
        {
          
            jointSpring.spring = springPower;
        }
        else
        {
            jointSpring.spring = 0;
        }
        hinge.spring = jointSpring;
    }

}
