using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Plunger : MonoBehaviour

{
  float power;
  float maxPower = 10f;
  float powerCountPerTick = 1;

  public Animator plungerAnim;

  Rigidbody ballRb;
  ContactPoint contact;

  bool ballReady;

  void Update ()
  {
		if(ballReady)
    {
      if(Input.GetKey(KeyCode.S))
      {
        if(power <= maxPower)
        {
          power += powerCountPerTick * Time.deltaTime;
        }
        plungerAnim.SetBool("activate",true);
        Debug.Log(power);
    }
    
    if(Input.GetKeyUp(KeyCode.S))
    {
      if(ballRb != null)
      {
        ballRb.AddForce(-1 * power * contact.normal,ForceMode.Impulse );
      }
      plungerAnim.SetBool("activate",false);
    }
    
    }
	}
  void OnCollisionEnter(Collision col)
  {
    ballReady = true;
    power = 0f;
    contact = col.contacts[0];
    ballRb = contact.otherCollider.attachedRigidbody;
  }
  void OnCollisionExit(Collision col)
  {
    ballReady = false;
    ballRb = null;
  }

}
