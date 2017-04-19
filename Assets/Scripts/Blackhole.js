#pragma strict
var respawn : Transform;

function OnTriggerEnter (other : Collider) {
    if (other.CompareTag ("Player")) {
        other.transform.position = respawn.position;
    }
}