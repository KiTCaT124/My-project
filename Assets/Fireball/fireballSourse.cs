using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballSourse : MonoBehaviour
{
    public Transform targetPoint;
    public Camera cameraLink;
    public float targerInSkyDistance;
    private void Update()
    {
        var ray = cameraLink.ViewportPointToRay(new Vector3(0.5f, 0.7f, 0f));

        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            targetPoint.position = hit.point;
        }
        else
        {
            targetPoint.position = ray.GetPoint(targerInSkyDistance);
        }

        transform.LookAt(targetPoint.position);
    }
}
