using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverCollisionChecker : MonoBehaviour {

    public bool IsCollisionOrnament;
    public Ornament CollisionOrnament;
    
    private void OnTriggerEnter( Collider other ) {
        if ( other.gameObject.tag == "Ornament" ) {
            CollisionOrnament = other.gameObject.GetComponent<Ornament>();
            IsCollisionOrnament = true;
        }
    }

    private void OnTriggerExit( Collider other ) {
        if ( other.gameObject.tag == "Ornament" ) {
            CollisionOrnament = null;
            IsCollisionOrnament = false;
        }
    }
}
