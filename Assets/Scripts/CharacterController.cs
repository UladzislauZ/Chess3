using System;

#if  UNITY_EDITOR
    using UnityEditor;
#endif

using UnityEngine;

namespace DefaultNamespace
{
    public class CharacterController : MonoBehaviour
    {
        [SerializeField] private CharacterData data;

        [SerializeField] private Transform[] legsTransform;
        [SerializeField] private Transform[] kneeTransform;
        [SerializeField] private Transform chestTransform;
        [SerializeField] private Transform neckTransform;
        [SerializeField] private Transform[] breastsTransforms;

        void UpdateCharacter()
        {
            foreach (var legTransform in legsTransform)
            {
                legTransform.localScale = data.GetLegSize(legTransform.localScale);
            }

            foreach (var kne in kneeTransform)
            {
                kne.localScale = data.GetKneeSize(kne.localScale);
            }

            foreach (var breas in breastsTransforms)
            {
                breas.localScale = data.GetBreastSize;
            }

            chestTransform.localScale = data.GetChestSize;
            neckTransform.localScale = data.GetNeckSize;
        }

        private void Start()
        {
            UpdateCharacter();
        }
#if UNITY_EDITOR
        private void Update()
        {
            if (Selection.activeGameObject != gameObject)
            {
                return;
            }
            UpdateCharacter();
        }
#endif
        
    }
}