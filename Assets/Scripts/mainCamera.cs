using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCamera : MonoBehaviour
{
    [SerializeField]Transform target;
    [SerializeField]Vector3 defaultDistance = new Vector3(0f, 2f, -10f);
    [SerializeField]float distanceDamp = 10f;
    [SerializeField]float rotationalDamp = 10f;
   


    Transform myT;

  
    void Awake() {
        myT = transform;
    }

    void LateUpdate() {

        Vector3 toPosition = target.position + (target.rotation * defaultDistance);
        Vector3 currentPosition = Vector3.Lerp(myT.position, toPosition, distanceDamp * Time.deltaTime);
        myT.position = currentPosition;

        Quaternion toRotation = Quaternion.LookRotation(target.position - myT.position, target.up);
        Quaternion currentRotation = Quaternion.Slerp(myT.rotation, toRotation,rotationalDamp * Time.deltaTime);
        myT.rotation = currentRotation;
    }
    

}
