using System;

namespace Military_Unit
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }

        private static void doWork()
        {
            Airplane c17 = new Airplane();
            FireTeam alpha = new FireTeam();
            MortarTeam bravo = new MortarTeam();
            Rifle m4 = new Rifle();
            MachineGun m240 = new MachineGun();
            Mortar one20 = new Mortar();
            alpha.loadVehicle();
            bravo.loadVehicle();
            c17.StartEngine("Contact");
            c17.Drive();
            c17.TakeOff();
            c17.Land();
            c17.StopEngine("Whirr");
            alpha.dismount();
            bravo.dismount();

            HMMWV a1 = new HMMWV();
            alpha.loadVehicle();
            a1.StartEngine("Brm Brm");
            a1.Accelerate();
            a1.Drive();
            alpha.receiveFire();
            alpha.returnFire();
            a1.Brake();
            alpha.dismount();
            m4.aim();
            m4.fire("Pew... Pew...");
            m4.reload();
            m240.aim();
            m240.fire("PEWPEWPEWPEWPEW");
            m240.reload();

            bravo.fireMiss();
            one20.aim();
            one20.load();
            one20.fire("Fire!!!");           
        }
    }
}
