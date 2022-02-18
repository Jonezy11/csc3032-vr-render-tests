using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class RControlTracker : MonoBehaviour
{
    List<InputDevice> rControllers = new List<InputDevice>();

    public Offsets offsets;

    // Start is called before the first frame update
    void Start()
    {
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Right, rControllers);
        List<InputFeatureUsage> usages = new List<InputFeatureUsage>();

    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            Vector3 pos;
            rControllers[0].TryGetFeatureValue(CommonUsages.devicePosition, out pos);
            pos = offsets.applyOffsets(pos);
            transform.position = new Vector3(pos.x, pos.y, pos.z);
        }
        catch (System.ArgumentOutOfRangeException)
        {
            Debug.Log("No R Controllers Found");
        }
    }
}
