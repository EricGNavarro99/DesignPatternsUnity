namespace Unity.TemplateMethod
{
    public class Warrior : Hero
    {
        protected override bool CanAttack()
        {
            if (currentHealth >= 30) return true;

            print("I am weak, I cannot attack!");

            return false;
        }

        protected override void DamagedRecieved(bool isDead) 
        {
            print("Bah! It did not hurt me!");

            if (isDead) print("Ahhh! It hurt me!");
        }

        protected override void DoAttack() => print("I gonna hurt you!");
    }
}
