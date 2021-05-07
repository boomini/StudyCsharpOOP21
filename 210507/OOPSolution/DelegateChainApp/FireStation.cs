using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChainApp
{

    delegate void ThereIsAFire(string location);
    class FireStation
    {
        public void Call119(String location) { Console.WriteLine($"소방서죠, 불났어요. 주소는 {location}입니다."); }
        public void ShotOut(String location) { Console.WriteLine($"피하세요!! {location}에 불났어요!!!"); }
        public void Escape(String location) { Console.WriteLine($"{location}에서 나갑시다!!"); }
    }
}
