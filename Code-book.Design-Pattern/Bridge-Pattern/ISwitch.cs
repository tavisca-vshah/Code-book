using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_book.Design_Pattern.Bridge_Pattern
{
    public interface ISwitch
    {
        void On();
        void Off();
    }

    public class Switch : ISwitch
    {
        private IEquipment equipment;

        public void SetEquipment(IEquipment equipment)
        {
            this.equipment = equipment;
        }
        public void Off()
        {
            equipment.Start();
        }

        public void On()
        {
            equipment.Stop();
        }
    }
}
