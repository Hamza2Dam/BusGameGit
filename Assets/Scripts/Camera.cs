using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour



{
    public Transform player;

    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y,player.position.z
            );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
