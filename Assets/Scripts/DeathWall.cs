using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathWall : MonoBehaviour
{
    // Almost all same to my MovingPlatform script vvv
    // Current version of code the wall does not reset scene on impact with the player, reason why is unknown.

    public Transform platform;
    public Transform start;
    public Transform end;
    public int direction = 1;
    public float speed = 0.2f;

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

    // collider so the player is killed on impact
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);

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
