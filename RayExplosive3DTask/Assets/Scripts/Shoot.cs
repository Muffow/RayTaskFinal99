using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Ray _ray;
    private RaycastHit _raycastHit;
    [SerializeField] private GameObject border;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoots();
        }
    }

    private void Shoots()
    {
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(_ray, out _raycastHit, float.MaxValue))
        {
            CreateShootImpact();
        }
    }

    private void CreateShootImpact()
    {
        Debug.Log("Lets go!");
        Destroy(border);
    }
}
