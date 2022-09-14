using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector4 mousePosition = GetMousePosition();
        //float radians = Mathf.Atan(mousePosition.y/ mousePosition.x) - Mathf.PI / 2;
        //Rotate(radians);
        LookAtMouse(mousePosition);
    }

    private void LookAtMouse(Vector3 mousePosition)
    {
        Vector3 thisPosition = new Vector2(transform.position.x, transform.position.y);
        Vector3 forward = mousePosition - thisPosition;
        float radians = Mathf.Atan2(forward.y, forward.x) - Mathf.PI / 2;
        Rotate(radians);
    }
    private Vector4 GetMousePosition()
    {
        Camera camera = Camera.main;
        Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);   
        Vector4 worldPos = camera.ScreenToWorldPoint(screenPos);
        return worldPos; 
    }

    private void Rotate(float radiant)
    {
        transform.rotation = Quaternion.Euler(0, 0, radiant * Mathf.Rad2Deg);
        
    }
}
