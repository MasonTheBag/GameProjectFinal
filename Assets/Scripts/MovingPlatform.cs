using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public Transform platform;
    public Transform start;
    public Transform end;
    public int direction = 1;
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        Vector3 target = currentMovementTarget();

        platform.position = Vector3.Lerp(platform.position, target, speed * Time.deltaTime);

        float distance = (target - (Vector3)platform.position).magnitude;

        if (distance <= 0.3f)
        {

            direction *= -1;

        }

    }

    public Vector3 currentMovementTarget()
    {

        if (direction == 1)
        {

            return start.position;

        }
        else
        {

            return end.position;

        }

    }

    private void OnDrawGizmos()
    {
        
        if (platform != null && start != null && end != null)
        {

            Gizmos.DrawLine(platform.transform.position, start.position);
            Gizmos.DrawLine(platform.transform.position, end.position);

        }


    }


}
