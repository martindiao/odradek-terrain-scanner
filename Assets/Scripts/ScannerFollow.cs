using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannerFollow : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Update_scanner_posrot();
    }

    // Update is called once per frame
    void Update()
    {
        Update_scanner_posrot();
    }

    void Update_scanner_posrot()
    {
        transform.position = player.transform.position;
        transform.rotation = Quaternion.Euler(new Vector3(0f, player.transform.rotation.eulerAngles.y, 0f));
    }
}
