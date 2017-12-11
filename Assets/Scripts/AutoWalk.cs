using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class AutoWalk : MonoBehaviour {

    public float speed = 5.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        var angles = InputTracking.GetLocalRotation(XRNode.Head);
        transform.Rotate(0, angles.y *= 7, 0, Space.Self);

        CharacterController controller = GetComponent<CharacterController>();
        moveDirection = transform.TransformDirection(Vector3.forward);
        moveDirection *= speed;
        controller.Move(moveDirection * Time.deltaTime);
    }

}
