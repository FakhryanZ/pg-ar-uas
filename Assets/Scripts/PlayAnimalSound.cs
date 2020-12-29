using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayAnimalSound : MonoBehaviour
{
    public GameObject buttonBunyi;
    public UnityEvent OnClick = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
        buttonBunyi = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var camera = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Input.GetMouseButtonDown(0)){
            if(Physics.Raycast(camera, out hit) && hit.collider.gameObject == gameObject){
                OnClick.Invoke();
            }
        }
    }
}
