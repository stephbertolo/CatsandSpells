using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Shake : MonoBehaviour
{

    // Public method called by other object with variable intensity and duration in seconds of shake
    public void Shake(float intensity, float duration)
    {

        StartCoroutine(ShakeRoutine(intensity, duration));
    }

    private IEnumerator ShakeRoutine(float intensity, float duration)
    {

        // When coroutine starts, start a timer at 0
        float time = 0.0f;
        // While time is lower than duration, repeat the shake
        while (time < duration)
        {
            // Increase time by time passed since last frame
            time += Time.deltaTime;
            // Generates a direction vector that is a random direction in any angle, but only in X and Z
            // not Y since we don't want the camera to change height
            Vector3 direction = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f)).normalized;
            // Apply the direction vector to the current camera position
            // multiplied by the intensity
            transform.position += direction * intensity;
            // Yield return null is necessary so all the code isn't executed in a single frame
            yield return null;
        }
    }
}
