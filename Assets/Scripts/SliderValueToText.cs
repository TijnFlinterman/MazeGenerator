using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Maze
{
    public class SliderValueToText : MonoBehaviour
    {
        #region Variables
        // public variables
        public Slider sliderUIHeight;
        public Slider sliderUIWidth;
        public TMP_Text textSliderValueHeight;
        public TMP_Text textSliderValueWidth;
        public MazeGenerator mazegenerator;
        #endregion

        #region ChangeValues
        public void Update()
        {
            ShowSliderValue(sliderUIHeight, textSliderValueHeight);
            ShowSliderValue(sliderUIWidth, textSliderValueWidth);
            mazegenerator.rows = (int)sliderUIWidth.value;
            mazegenerator.columns = (int)sliderUIHeight.value;
        }
        #endregion

        #region ChangeUI
        public void ShowSliderValue(Slider _slider, TMP_Text _text)
        {
            _text.text = _slider.value.ToString();
        }
        #endregion
    }
}