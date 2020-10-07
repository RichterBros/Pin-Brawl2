using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(MeshCollider))]
public class Bumper : MonoBehaviour
{
  public int scoreValue = 100;
	// Use this for initialization
	
  [SerializeField] float power = 1f;
  Animator anim;
  
  void Start()
  {
    anim = GetComponentInChildren<Animator>();

	}
	
	void OnCollisionEnter(Collision col)
  {
    foreach(ContactPoint contact in col.contacts)
    {
        contact.otherCollider.attachedRigidbody.AddForce(-1 * contact.normal * power, ForceMode.Impulse);
    }

    if(anim !=null)
    {
      anim.SetTrigger("activate");
    }
  
  // if(GameManager.playerScoring == 1)
  // {
  // ScoreManager1.playerOneScore += scoreValue;
  // }
  // if(GameManager.playerScoring == 2)
  // {
  // ScoreManager1.playerTwoScore += scoreValue;
  // }

  if(col.gameObject.CompareTag("ball1"))
     {
     ScoreManager1.playerOneScore += scoreValue;
     //ScoreManager1.playerOneScore = scoreValue;
     }
      
    if(col.gameObject.CompareTag("ball2"))
     {
     
     ScoreManager1.playerTwoScore += scoreValue;
     }
  
  
  }
}
