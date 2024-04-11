using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagEnd : MonoBehaviour
{
	public GameObject gameWinPanel;
	public void Start()
	{
		//Dat gia tri trong PlayerPrefs voi khoa la ten cua canh hien tai đang chay va gia tri la 1.
		//danh dau 1 cap do da duoc mo khoa
		PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, 1);
	}
	private void OnTriggerEnter2D(Collider2D other)//kich hoat khi player cham vao la co chuyen level 2
	{
		if (other.CompareTag("Player"))
		{
			gameWinPanel.SetActive(true);
										
		}
		//PlayerPrefs.DeleteAll();//lam sach du lieu khi chuyen qua level moi

	}

}
