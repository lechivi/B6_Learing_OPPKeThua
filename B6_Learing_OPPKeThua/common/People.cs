using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6_Learing_OPPKeThua.common
{
    //Base class
    internal class People
    {
        protected string name;
        protected string gender;

        public string Name => this.name;
        public string Gender => this.gender;

        //Muc dich cua constructor: tao du lieu ban dau cho doi tuong
        //Ham khoi tao mac dinh, ham dựng
        public People()
        {
            this.name = " ";
            this.gender = " ";
        }

        //Ham khoi tao co tham so
        public People(string name, string gender)
        {
            this.name = name;
            this.gender = gender;
        }

        //ham thanh phan
        public void OutputPeople()
        {
            Console.WriteLine("Name: " + this.name + "; Gender: " + this.gender);
        }

        public override string ToString()
        {
             return "Name: " + this.name + "; Gender: " + this.gender;

        }
    }

}
