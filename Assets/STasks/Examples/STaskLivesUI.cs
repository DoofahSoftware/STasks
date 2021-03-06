﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace STasks.Examples
{
    public class STaskLivesUI : MonoBehaviour
    {
        [SerializeField]
        private Text _text;

        public void SetLives(int lives)
        {
            _text.text = $"Lives: {lives}";
        }
    }
}