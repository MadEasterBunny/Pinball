using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    private HingeJoint myHingeJoint;

    private float defaultAngle = 20;
    private float flickAngle = -20;

    //private bool isLButtonDown = false;
    //private bool isRButtonDown = false;

	// Use this for initialization
	void Start ()
    {
        this.myHingeJoint = GetComponent<HingeJoint>();
        SetAngle(this.defaultAngle);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFlipperTag")
        {
            SetAngle(this.flickAngle);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFlipperTag")
        {
            SetAngle(this.flickAngle);
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFlipperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if(Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFlipperTag")
        {
            SetAngle(this.defaultAngle);
        }
    }

    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }

    /*public void GetMyLeftButtonDown()
    {
        isLButtonDown = true;
    }

    public void GetMyLeftButtonUp()
    {
        isLButtonDown = false;
    }

    public void GetMyRightButtonDown()
    {
        isRButtonDown = true;
    }

    public void GetMyRightButtonUp()
    {
        isRButtonDown = false;
    }*/
}
