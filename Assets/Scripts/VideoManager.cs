using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR.LegacyInputHelpers;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{

    public GameObject sphereOne;
    public GameObject sphereTwo;
    public GameObject sphereThree;
    public VideoPlayer sphereOneVideoPlayer;
    public VideoPlayer sphereTwoVideoPlayer;
    public VideoPlayer sphereThreeVideoPlayer;
    public GameObject Origin;
    //public GameObject cameraoffset;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        sphereOneVideoPlayer.Play();
        sphereTwoVideoPlayer.Play();
        sphereThreeVideoPlayer.Play();
        Debug.Log("Play");
    }


    public void Pause()
    {
        sphereOneVideoPlayer.Pause();
        sphereTwoVideoPlayer.Pause();
        sphereThreeVideoPlayer.Pause();
        Debug.Log("Pause");
    }

    public void Orchestra()
    {
        Vector3 nextVectorPosition = new Vector3(50, 0, 0);
        //sphereTwo.transform.rotation = Quaternion.AngleAxis( 64, Vector3.up);
        Origin.transform.position = nextVectorPosition;
        Debug.Log("FIRED!!!!");
        Debug.Log(Origin.transform.position);
    }

    public void Conductor()
    {
        Vector3 nextVectorPosition = new Vector3(0, 0, 0);
        //cameraoffset.transform.rotation = Quaternion.AngleAxis( 137, Vector3.up);
        Origin.transform.position = nextVectorPosition;
    }

    public void Crowd()
    {
        Vector3 nextVectorPosition = new Vector3(100, 0, 0);
        //cameraoffset.transform.rotation = Quaternion.Euler(0, -93, 0);
        Origin.transform.position = nextVectorPosition;
    }
}

