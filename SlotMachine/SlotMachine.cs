using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    public class SlotMachine
    {
        private string _seven = "7";
        private string _hashtag = "#";
        private string _snail = "@";
        private int _credit;


        public SlotMachine()
        {
            //BLEH
        }

        public string Seven
        {
            get { return _seven; }
        }

        public string Hashtag
        {
            get { return _hashtag; }
        }

        public string Snail
        {
            get { return _snail; }
        }

        public int Credit
        {
            get { return _credit; }
        }

        public void AddCredits(int noOfCredits)
        {

        }

        public int GetCredits()
        {
            return 1;
        }

        public void Spin()
        {

        }

    }

}
