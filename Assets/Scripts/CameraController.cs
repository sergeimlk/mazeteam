using UnityEngine;
using System.Collections;

public class CameraCotroller : MonoBehaviour
{
   [SerializeField] private GameObject target; // Référence à la balle
   [SerializeField] private Vector3 offset; // Référence à la balle

    void Start()
    {
    }

    void Update()
    {
        transform.position = target.transform.position + offset;
    }
}
