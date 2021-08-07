using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CarLibrary
{
    public class SportCar : Car
    {
        public SportCar()
        {}
        public SportCar(string name,int maxSp,int currSp):base(name,maxSp,currSp)
        {}
        public override void TurboBoost()
        {
            MessageBox.Show("Ramming speed!", "Faster is better...");
        }
    }
    public class MiniVan : Car
    {
        public MiniVan()
        { }
        public MiniVan(string name, int maxSp, int currSp) : base(name, maxSp, currSp)
        { }
        public override void TurboBoost()
        {
            //Minivan have poor turbo capabilities
            egnState = EngineState.engineDead;
            MessageBox.Show("Eek!", "Your engine block exploded!...");
        }
    }
    
}
