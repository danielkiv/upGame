//script for paralax
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    //vars
    public Transform[] backgrounds;
    private float[] pScales;
    public float smoothing;
    private Transform cam;
    private Vector3 prevCamPos;

    void Awake()
    {
        cam = Camera.main.transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        prevCamPos = cam.position;

        pScales = new float[backgrounds.Length];

        for (int i = 0; i < backgrounds.Length; i++)
        {
            pScales[i] = backgrounds[i].position.z * -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            float parallax = (prevCamPos.x - cam.position.x) * pScales[i];

            float backgroundTargetPosX = backgrounds[i].position.x + parallax;

            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }
        prevCamPos = cam.position;
    }
}
