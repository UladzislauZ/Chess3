using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class SoundGroup : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private SoundInfo[] sounds;

        public string ID => id;

        public string[] GetIds()
        {
            return sounds.Select(s => s.ID).ToArray();
        }

        public SoundInfo GetSoundInfo(string soundID)
        {
            return sounds.FirstOrDefault((s => s.ID == soundID));
        }
    }
}