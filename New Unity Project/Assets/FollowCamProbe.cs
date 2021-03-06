using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamProbe : MonoBehaviour
{

    ReflectionProbe probe;

    private void Awake()
    {
        probe = GetComponent<ReflectionProbe>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        probe.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y * -1, Camera.main.transform.position.z);
        probe.RenderProbe();
    }
}
