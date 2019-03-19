using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    public float horizontalSpeed = 0F;
    public float verticalSpeed = 0F;
	public float movmentSpeed = 3F;

        public Rigidbody rb;
        void Update() {
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float v = -verticalSpeed * Input.GetAxis("Mouse Y");
            transform.Rotate(0, h, 0);
            GameObject cam = GameObject.Find("Camera");
            cam.transform.Rotate(v, 0, 0);


            //rb.AddForce(Input.GetAxis("Horizontal") * Time.deltaTime * movmentSpeed, 0, Input.GetAxis("Vertical")* Time.deltaTime);
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * movmentSpeed, 0, Input.GetAxis("Vertical")* 	Time.deltaTime * movmentSpeed);

			if(Input.GetAxis("Jump") > 0) {

    			RaycastHit hit;
     			if (Physics.Raycast(transform.position, -Vector3.up, out hit)) {
         			float distanceToGround = hit.distance;
    				if(distanceToGround < transform.localScale.y + 0.001) {
						if(Input.GetAxis("Jump") > 0) {
							rb.AddForce(0, 20000 * Time.deltaTime, 0);
							Debug.Log(distanceToGround);
					}
				}	
			}
    	}
	}
}