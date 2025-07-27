using UnityEngine;
using System;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
	[Serializable]
	public struct PlayerStats
	{
		public int MovementSpeed;
		public int HitPoints;
		public bool HasHealthPotion;
	}

	[SerializeField]
	private PlayerStats m_stats;
	
	// 멀티 레벨 타입 인스펙터 표시 테스트
	[SerializeField]
	private Dictionary<string, int> m_statsDictionary = new Dictionary<string, int>();
}
