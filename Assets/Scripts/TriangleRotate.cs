using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleRotate : MonoBehaviour
{
    public void Rotate(float amount)
    {
        transform.Rotate(0, 0, amount);
    }


}
