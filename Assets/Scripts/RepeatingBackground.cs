using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    [Tooltip("How fast does this object move ?")]
    public float scrollSpeed;

    public const float ScrollWidth = 8;

    private void FixedUpdate()
    {
        Vector3 pos = transform.position;

        pos.x -= scrollSpeed * Time.deltaTime * GameController.speedModifire;

        if(transform.position.x < -ScrollWidth)
        {
            Offscreen(ref pos);
        }

        transform.position = pos;

    }

    protected virtual void Offscreen(ref Vector3 pos)
    {
        pos.x += 2 * ScrollWidth;
    }
}
