using System;
using System.Collections.Generic;
using UnityEngine;

public class CallbackDictionary : MonoBehaviour, ISerializationCallbackReceiver
{
	// 직렬화할 임시 저장소
	public List<string> m_keys = new List<string> {"HP", "MP", "EXP"};
	public List<int> m_values = new List<int> {100, 50, 0};
	
	// 런타임에 사용할 실제 딕셔너리
	public Dictionary<string, int> m_statsDictionary = new Dictionary<string, int>();

	// Unity 직렬화 이전에 호출됨
	public void OnBeforeSerialize()
	{
		m_keys.Clear();
		m_values.Clear();
		
		foreach (var pair in m_statsDictionary)
		{
			m_keys.Add(pair.Key);
			m_values.Add(pair.Value);
		}
	}
	
	// Unity 직렬화 이후에 호출됨
	public void OnAfterDeserialize()
	{
		m_statsDictionary = new Dictionary<string, int>();
		for (int i = 0; i != Math.Min(m_keys.Count, m_values.Count); i++)
		{
			m_statsDictionary.Add(m_keys[i], m_values[i]);
		}
	}

	void OnGUI()
	{
		foreach (var pair in m_statsDictionary)
		{
			GUILayout.Label($"{pair.Key} : {pair.Value}");
		}
	}
}
