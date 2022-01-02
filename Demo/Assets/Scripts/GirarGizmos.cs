using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarGizmos : MonoBehaviour
{
    public GameObject personaje;

    private void LateUpdate()
    {
        transform.eulerAngles = new Vector3(90, 0, personaje.transform.eulerAngles.y);
    }
}