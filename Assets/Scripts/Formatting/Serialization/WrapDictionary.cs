using System;
using System.Collections.Generic;
using UnityEngine;

// 딕셔너리 Key-Value 값을 담을 Wrapper 클래스
// [System.Serializable] 로 클래스를 직렬화함.
[System.Serializable]
public class StringIntPair
{
    public string Key;
    public int Value;
}
public class WrapDictionary : MonoBehaviour
{
    // Inspector엔 Wrapper클래스를 담은 List를 직렬화함.
    [SerializeField]
    private List<StringIntPair> m_statsPairList;
    
    // 실제 사용하는 Dictionary(직렬화 불가)
    private Dictionary<string, int> m_statsDictionary = new Dictionary<string, int>();

    // 시작 시, List 값들을 Dictionary로 추가함.
    private void Awake()
    {
        foreach (var pair in m_statsPairList)
        {
            if (!m_statsDictionary.TryAdd(pair.Key, pair.Value))
            {
                Debug.LogWarning($"Key {pair.Key} is already in dictionary");
            }
        }

        // 테스트
        foreach (var pair in m_statsDictionary)
        {
            Debug.Log($"{pair.Key} : {pair.Value}");
        }
    }
}
