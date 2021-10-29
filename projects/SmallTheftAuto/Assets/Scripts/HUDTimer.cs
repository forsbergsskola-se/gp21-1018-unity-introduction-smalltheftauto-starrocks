using UnityEngine;
using UnityEngine.UI;

public class HUDTimer : MonoBehaviour {
	private Text timerText;
	private float timePassed;
	private int minutesPassed;
	
	void Start()
	{
		timerText = GetComponent<Text>();
	}

	void Update() {
		timePassed += Time.deltaTime;
		timerText.text = minutesPassed + "m " + timePassed.ToString("0.00") + "s";
		if (timePassed >= 60) {
			minutesPassed++;
			timePassed %= 60;
		}
	}
}
