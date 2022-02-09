using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Character : MonoBehaviour
    {
        [SerializeField] protected CharacterInfo _characterInfo;
        [SerializeField] private Image healthSlider;

        protected float maxHp;

        private void OnEnable()
        {
            maxHp = _characterInfo.Hp;
            
            OnHpChanged(maxHp);

            _characterInfo.Hp.Variable.OnValueChanged += OnHpChanged;
        }

        private void OnDisable()
        {
            _characterInfo.Hp.Variable.OnValueChanged -= OnHpChanged;
        }

        private void OnHpChanged(float hp)
        {
            healthSlider.fillAmount = hp / maxHp;
        }
    }
}