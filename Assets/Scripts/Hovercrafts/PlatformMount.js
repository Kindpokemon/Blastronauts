#pragma strict
public var activePlatform : Transform;
private var activeLocalPlatformPoint : Vector3;
private var activeGlobalPlatformPoint : Vector3;
private var lastPlatformVelocity : Vector3;
public var controller : Rigidbody;

// If you want to support moving platform rotation as well:
private var activeLocalPlatformRotation : Quaternion;
private var activeGlobalPlatformRotation : Quaternion;


function Update () {


 // Perform gravity and jumping calculations here
 ...
 // Moving platform support
 if (activePlatform != null) {
     var newGlobalPlatformPoint = activePlatform.TransformPoint(activeLocalPlatformPoint);
     var moveDistance = (newGlobalPlatformPoint - activeGlobalPlatformPoint);
     if (moveDistance != Vector3.zero)
             controller.Move(moveDistance);
     lastPlatformVelocity = (newGlobalPlatformPoint - activeGlobalPlatformPoint) / Time.deltaTime;
     // If you want to support moving platform rotation as well:
     var newGlobalPlatformRotation = activePlatform.rotation * activeLocalPlatformRotation;
     var rotationDiff = newGlobalPlatformRotation * Quaternion.Inverse(activeGlobalPlatformRotation);
     // Prevent rotation of the local up vector
     rotationDiff = Quaternion.FromToRotation(rotationDiff * transform.up, transform.up) * rotationDiff;
     transform.rotation = rotationDiff * transform.rotation;
 }
 else {
     lastPlatformVelocity = Vector3.zero;
 }
 // Actual movement logic here
 ...
 collisionFlags = myCharacterController.Move (calculatedMovement);
 ...
 // Moving platforms support
 if (activePlatform != null) {
     activeGlobalPlatformPoint = transform.position;
     activeLocalPlatformPoint = activePlatform.InverseTransformPoint (transform.position);
     // If you want to support moving platform rotation as well:
     activeGlobalPlatformRotation = transform.rotation;
     activeLocalPlatformRotation = Quaternion.Inverse(activePlatform.rotation) * transform.rotation; 
 }

}


function OnControllerColliderHit (hit : ControllerColliderHit) {
    // Make sure we are really standing on a straight platform
    // Not on the underside of one and not falling down from it either!
    if (hit.moveDirection.y < -0.9 && hit.normal.y > 0.5) {
        activePlatform = hit.collider.transform;  
    }
}