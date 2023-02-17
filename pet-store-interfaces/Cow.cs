using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store_interfaces {
    internal class Cow : IPet {
        public string Name { get; set; }
        public string Speak() {
            return "Quack!";
        }

        public void MilkYourself() {

        }

        public void GetYourOwnHay() {

        }
    }
}
