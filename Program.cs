/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initialization
{
    /* To simplify object initialization, any accessible fields or properties of
     an object can be set via an object initializer directly after construction.
     For example, consider the following class: */
    public class Bunny
    {
        public string Name;
        public bool LikesCarrots;
        public bool LikesHumans;

        public Bunny() { }
        public Bunny (string n) { Name = n; }
    }
    class Program
    {
        static void Main()
        {
            // Using object initializers, you can instantiate Bunny objects as follows:
            // Note paramaterless constructors can omit empty parentheses
            Bunny b1 = new Bunny { Name = "Bo", LikesCarrots = true, LikesHumans = false };
            Bunny b2 = new Bunny("Bo") { LikesCarrots = true, LikesHumans = false };
            // The code to construct b1 and b2 is precisely equvialent to:
            Bunny temp1 = new Bunny();
            temp1.Name = "Bo";
            temp1.LikesCarrots = true;
            temp1.LikesHumans = false;
            Bunny b3 = temp1;

            Bunny temp2 = new Bunny("Bo");
            temp1.LikesCarrots = true;
            temp1.LikesHumans = false;
            Bunny b4 = temp1;
            /* The temporary variables are to ensure that if an exception is thrown during
             initialization, you can't end up with a half-initialized object. */
        }
    }
}
