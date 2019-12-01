using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public GameObject target;
    private const float MAX_DIST = 15.0f;
    private const float MIN_DIST = 2.0f;
    private const float SCROLL_SPEED = 2.5f;
    private float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 20.0f;

    private const float MIN_ANGLE = 0.0f;
    private const float MAX_ANGLE = 40.0f;

    private void Update()
    {
        // currentX += Input.GetAxis("Mouse X");
        // currentY += Input.GetAxis("Mouse Y");

        // currentY = Mathf.Clamp(currentY, MIN_ANGLE, MAX_ANGLE);

        // if (Input.GetAxis("Mouse ScrollWheel") > 0f) {
        //     distance = Mathf.Clamp(distance - SCROLL_SPEED, MIN_DIST, MAX_DIST);
        // } else if (Input.GetAxis("Mouse ScrollWheel") < 0f) {
        //     distance = Mathf.Clamp(distance + SCROLL_SPEED, MIN_DIST, MAX_DIST);
        // }
    }
    private void LateUpdate() {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = target.transform.position + rotation * dir;

        transform.LookAt(target.transform.position);
    }
}
