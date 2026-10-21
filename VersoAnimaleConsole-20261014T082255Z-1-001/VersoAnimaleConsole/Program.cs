namespace Animale
{
    using System;

    public abstract class Animale
    {
        public abstract int Età();
        public abstract void Verso();

    }

    public class Cane : Animale
    {

        public override int Età()
        {
            return 5;
        }
        public override void Verso()
        {
            Console.WriteLine(" Bau bau!");
        }
    }

    public class Gatto : Animale
    {
        public override int Età()
        {
            return 5;
        }
        public override void Verso()
        {
            Console.WriteLine(" Miao!");
        }
    }

    public class Uccello : Animale
    {

        public override int Età()
        {
            return 5;
        }
        public override void Verso()
        {
            Console.WriteLine("Cip cip!");
        }
    }



}
//classe animaale nome, età + tanti metodi astratti per cose diverse che gli animali devono saper fare