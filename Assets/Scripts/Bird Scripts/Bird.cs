using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
  private float forwardSpeed = 3f;
	private float bounceSpeed = 4f;

  private bool didFlap;

  [SerializeField]
	private Rigidbody2D myRigidBody;

    
  // Start is called before the first frame update
  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {
      
  }
  void FixedUpdate () 
  {
    Vector3 temp = transform.position;
    temp.x += forwardSpeed * Time.deltaTime;
    transform.position = temp;

    if(didFlap) {
				didFlap = false;
				myRigidBody.velocity = new Vector2(0, bounceSpeed);
        // audioSource.PlayOneShot(flapClick);
				// anim.SetTrigger("Flap");
			}
  }

  protected void flap()
  {
    didFlap = true;
  }
}
