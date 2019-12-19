using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    private Renderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    public void OnEnter()
    {
        _renderer.material.color = Color.red;
    }

    public void OnExit()
    {
        _renderer.material.color = Color.white;
    } 

    public void OnGrab()
    {
        Transform pointerTransform = GvrPointerInputModule.Pointer.PointerTransform;
        transform.SetParent(pointerTransform, true);
        _renderer.material.color = Color.blue;
    }

    public void OnRelease()
    {
        transform.SetParent(null, true);
        _renderer.material.color = Color.green;
    }
}
