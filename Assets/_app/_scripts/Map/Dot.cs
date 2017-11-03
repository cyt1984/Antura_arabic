﻿using Antura.Core;
using DG.Tweening;
using UnityEngine;

namespace Antura.Map
{
    /// <summary>
    /// A dot on the map. Just visuals. 
    /// </summary>
    public class Dot : MonoBehaviour
    {
        [Header("References")]
        public Material blackDot;
        public Material redDot;

        public void Highlight(bool choice)
        {
            GetComponent<Renderer>().material = choice ? redDot : blackDot;
        }

        #region Appear / Disappear

        public bool Appeared { get; private set; }

        public void Disappear()
        {
            Appeared = false;
            transform.localScale = Vector3.one * 0.5f;
        }

        public void Appear(float delay, float duration)
        {
            if (Appeared) return;
            Appeared = true;
            transform.DOScale(Vector3.one * 1.5f, duration)
                .SetEase(Ease.OutElastic)
                .SetDelay(delay);
        }

        public void FlushAppear()
        {
            if (Appeared) return;
            Appeared = true;
            transform.localScale = Vector3.one * 1.5f;
        }

        #endregion
    }
}