using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CarLibrary
{
    //represents the state of the engine
    public enum EngineState
    { engineAlive, engineDead }
    public enum MusicMedia
    {
        musicCd,
        musicTape,
        musicRadio,
        musicMp3
    }
    //the abstract base  class in the hierarchy
    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }


        protected EngineState egnState = EngineState.engineAlive;
        public EngineState EngineState => egnState;

        public abstract void TurboBoost();
        public void TurnOnRadio(bool musicOn, MusicMedia mm)=>MessageBox.Show(musicOn ? $"Jamming {mm}" : "Quite Time ...");

        
        public Car() => MessageBox.Show("CarLibrary Version 2.2.1.0!");
        public Car(string name, int maxSp, int currSp)
        {
            MessageBox.Show("CarLibrary Version 2.2.1.0!");
            PetName = name;MaxSpeed = maxSp;CurrentSpeed = currSp;

        }
        public void CarGift(Car c)
        {
            Console.WriteLine("I can't thank you enough" +
                "for giving {0} as a gift",c.PetName);
        }
    }
}
