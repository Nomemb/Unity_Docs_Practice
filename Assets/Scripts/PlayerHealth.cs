using UnityEngine;

public class PlayerHealth
{
	// Private 지원 필드
	private int m_maxHealth;
	
	// 읽기 전용, 지원 필드 반환
	// 한 줄로 작성된 읽기 전용 프로퍼티는 => 표현식 사용
	// public int MaxHealth => m_maxHealth;

	// 위 코드는 다음과 같음
	// public int MaxHealth { get; private set; }
	
	// 명시적으로 getter와 setter를 구현하는 경우
	public int MaxHealth
	{
		get => m_maxHealth;
		set => m_maxHealth = value;
	}
	
	// 쓰기 전용(지원 필드를 사용하지 않음)
	public int Health { private get; set; }
	
	// 쓰기 전용, 명시적인 setter가 없는 경우
	public int SetMaxHealth(int newMaxValue) => m_maxHealth = newMaxValue;
}
