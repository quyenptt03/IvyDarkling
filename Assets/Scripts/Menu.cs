﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
	public GameObject panel;
	public GameObject settingSound;
	public void LoadScene(string sceneName)
    {
		StartCoroutine(FadeIn(sceneName));
    }

	public void Quit()
	{
		//thoat khoi game
		Application.Quit();
	}
	IEnumerator FadeIn(string sceneName)
	{
		panel.SetActive(true);
		yield return new WaitForSeconds(0.5f);//yied tra ve trong vai giay. xem canh Mantia Dot Lourdes truoc khi bat dau canh Game
		SceneManager.LoadScene(sceneName);//tai mot scene moi trong game
	}
	public void ToggleOptionsPanel()
	{
		if (settingSound.activeSelf) // Nếu bảng tùy chọn đang hiển thị
		{
			settingSound.SetActive(false); // Ẩn bảng tùy chọn
		}
		else
		{
			settingSound.SetActive(true); // Hiển thị bảng tùy chọn
		}
	}
}
