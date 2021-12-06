using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    Transform target;
    [SerializeField]
    Vector3 offset = new Vector3(0, 2, -5);

    [SerializeField]
    float damping;

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            float lerpedX = Mathf.Lerp(transform.position.x, target.position.x + offset.x, Time.deltaTime * damping);
            float lerpedY = Mathf.Lerp(transform.position.y, target.position.y + offset.y, Time.deltaTime * damping);
            float lerpedZ = Mathf.Lerp(transform.position.z, target.position.z + offset.z, Time.deltaTime * damping);

            transform.position = new Vector3(lerpedX, lerpedY, lerpedZ);

            transform.LookAt(target);
        }
    }

    public void FollowMe(Transform playerTr) {
        if (target == null) {
            target = playerTr;
        }
    }
   

}
