using TMPro;
using UnityEngine;

namespace LethalConfig.MonoBehaviours
{
    internal class ConfigInfoBox : MonoBehaviour
    {
        public TextMeshProUGUI configInfoText;

        public void SetConfigInfo(string configInfo)
        {
            configInfoText.text = configInfo;
        }
    }
}
