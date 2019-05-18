using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
      if (BirdPlayer.instance != null) {
				if(BirdPlayer.instance.isAlive) {
					MoveTheCamera();
				}
			}
    }
 
    void MoveTheCamera() {
			Vector3 temp = transform.position;
			temp.x = BirdPlayer.instance.GetPositionX ();
			transform.position = temp;
		}
}
