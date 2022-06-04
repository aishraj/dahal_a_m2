using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSpehereReporter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.impulse.magnitude > 0.25f)
        {
            //we'll just use the first contact point for simplicity
            EventManager.TriggerEvent<BombBounceEvent, Vector3>(collision.contacts[0].point);
        }
    }
}
