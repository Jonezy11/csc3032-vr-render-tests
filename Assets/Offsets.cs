using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offsets : MonoBehaviour
{
    public Transform camOffset;

	private List<Vector3> offsets;

	private void Start()
	{
		offsets = new List<Vector3>();
		offsets.Add(camOffset.position);
	}

	public Vector3 applyOffsets(Vector3 pos) 
    {
		foreach (Vector3 v in offsets) 
		{
			pos += v;
		}
		return pos;
    }

	public void addOffsetToList(Vector3 offset) 
	{
		offsets.Add(offset);
	}
}
