using UnityEngine;

namespace Unity.TemplateMethod
{
    public class Consumer : MonoBehaviour
    {
        [SerializeField] private Hero heroA;
        [SerializeField] private Hero heroB;

        private void Awake()
        {
            print("-----");
            Do(heroA, "HeroA");
            print("-----");
            Debug.Break();
            Do(heroB, "HeroB");
        }

        private static void Do(Hero hero, string heroName)
        {
            hero.OnDamageRecieved += () => { print($"{heroName} recieved damage."); };
            hero.RecievedDamage(10);
            hero.Attack();
            hero.RecievedDamage(70);
            hero.Attack();
            hero.RecievedDamage(100);
        }
    }
}
