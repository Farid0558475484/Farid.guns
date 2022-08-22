using System;
using System.Threading;


namespace Farid111
{
    public class Weapons
    {
        private int _magazineCapacity; //Darağın güllə tutumu
        private int _memberOfBulletsRemaining; //Daraqdakı güllə sayı,
        private float _discharheSecond; // Darağın boşalma saniyəsi
        private string _fireMode; //atış modu


        public Weapons(int magazineCapacity, int memberOfBulletsRemaining, double discharheSecond, string fireMode)
        {
            this.MagazineCapacity = MagazineCapacity;
            this.MemberOfBulletsRemaining = MemberOfBulletsRemaining;
            this.DischarheSecond = DischarheSecond;
            this.FireMode = FireMode;
        }

        public int MagazineCapacity //Darağın güllə tutumu
        {
            get
            {
                return _magazineCapacity;
            }
            set
            {
                if (MagazineCapacity >= 0)

                {
                    _magazineCapacity = value;
                }
            }
        }


        public int MemberOfBulletsRemaining //Daraqdakı güllə sayı,
        {
            get
            {
                return _memberOfBulletsRemaining;
            }
            set
            {
                if (MemberOfBulletsRemaining >= 0)
                {
                    _memberOfBulletsRemaining = value;
                }
            }

        }


        public float DischarheSecond // Darağın boşalma saniyəsi
        {
            get
            {
                return _discharheSecond;
            }
            set
            {
                if (DischarheSecond > 0)
                {
                    _discharheSecond = value;
                }
            }
        }

        public string FireMode //atış modu
        {

            get
            {
                return _fireMode;
            }
            set
            {
                if (FireMode == "Single" && FireMode == "Auto")
                    _fireMode = value;
            }
        }

        public void ChangeFireMode() //Atış modunu dəyişir.
        {
            if (FireMode != "Auto")
            {
                Console.WriteLine("Auto");
            }
            else if (FireMode != "Single")
            {
                Console.WriteLine("Single");
            }


        }





        public void Shoot()  // metodu hər çağırıldıqda 1 güllə atır(Ekranda bunu bildir)
        {
            if (MemberOfBulletsRemaining > 0)
            {
                MemberOfBulletsRemaining--;
                Console.WriteLine("Shoot one bullet");

            }
            else
                Reload();

        }
        public void Fire() //metodu daraqdakı güllələr hamısı atəşlənir və neçə saniyəyə bitdiyi qeyd olunur.
        {

            double time = DischarheSecond / MagazineCapacity * MemberOfBulletsRemaining;
            Console.WriteLine(time + " : Time");
        }


        public int GetRemainBulletCount()  //darağın tam dolması üçün lazım olan güllə sayını qaytarır.
        {
            int count = MagazineCapacity - MemberOfBulletsRemaining;

            return count;
        }




        public void Reload() //darağı yenidən doldurur
        {
            if (MemberOfBulletsRemaining == MagazineCapacity)
            {
                Console.WriteLine("Don't reload");
            }
            else
            {


                Console.WriteLine("Reloding...");

                Thread.Sleep((int)(1000 * 4));
                Console.Clear();
                Console.WriteLine("Reloded");
            }



            

        }
    }
}

