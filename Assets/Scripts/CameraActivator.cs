using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraActivator : MonoBehaviour
{
	public CinemachineVirtualCamera m_ActivatedCamera;

	void OnTriggerEnter(Collider coll)
	{
		m_ActivatedCamera.m_Priority = 11;
	}

	void OnTriggerExit(Collider coll)
	{
		m_ActivatedCamera.m_Priority = 9;
	}
}
