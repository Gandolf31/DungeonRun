using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class HealthSystem : MonoBehaviour
{
	public static HealthSystem Instance;
	public Image currentHealthBar;
	public float hitPoint = 100f;
	public float maxHitPoint = 100f;
	void Awake()	// 인스턴스 로딩될 때 호출
	{
		Instance = this;
	}
  	void Start()
	{
		UpdateHealthBar();
	}
	private void UpdateHealthBar()
	{
		float ratio = hitPoint / maxHitPoint;
		currentHealthBar.rectTransform.localPosition = 
		new Vector3(currentHealthBar.rectTransform.rect.width * ratio - currentHealthBar.rectTransform.rect.width, 0, 0);
	}
	public void TakeDamage(float Damage)
	{
		hitPoint -= Damage;
		if (hitPoint < 1)
			hitPoint = 0;
		UpdateHealthBar();
	}
}