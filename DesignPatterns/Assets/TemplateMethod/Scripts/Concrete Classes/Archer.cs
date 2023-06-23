using System.Runtime.InteropServices.WindowsRuntime;

namespace Unity.TemplateMethod
{
    public class Archer : Hero
    {
        protected override bool CanAttack() => true;   

        protected override void DamagedRecieved(bool isDead)
        {
            if (isDead)
            {
                print("Oh no! I am dying");
                return;
            }

            print("Emm... okey so!");
        }

        protected override void DoAttack() => print("An arrow for you monster!");
    }
}
