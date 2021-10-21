using UnityEngine;
using UnityEngine.UI;

public class TimerBT : MonoBehaviour {
	public Text timerText;
	private float timePassed;
	private int minutesPassed;

	void Update() {
		//set timer UI
		timePassed += Time.deltaTime;
		timerText.text = minutesPassed + "m " + timePassed.ToString("0.00") + "s";
		if (timePassed >= 60) {
			minutesPassed++;
			timePassed %= 60;
		}
	}
}
