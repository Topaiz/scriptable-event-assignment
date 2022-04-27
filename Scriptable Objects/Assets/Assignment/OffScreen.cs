using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScreen : MonoBehaviour
{
    public void OnLeftScreen(Vector2 curPos) {
        transform.position = new Vector2(curPos.x * -1, curPos.y * -1);
    }
}
