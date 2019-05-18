using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPlayer : Bird
{
    public static BirdPlayer instance;
    private float forwardSpeed = 30f;

    public bool isAlive;
    void Awake()
    {
        if (instance == null) {
			instance = this;
		}

		isAlive = true;		
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void flapButton()
    {
        flap();        
    }

    public float GetPositionX()
    {
        return transform.position.x;
    }
    void SetCamerasX() {
		// CameraController.offsetX = (Camera.main.transform.position.x - transform.position.x) - 1f;
	}
}
