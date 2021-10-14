﻿/***************************************************
 * Demonstrate an Interface
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * *************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearPizza {
    /// <summary>
    /// Set up a rudimentary test for the NuclearPizza class
    /// </summary>
    class Program {
        static void Main(string[] args) {
            NuclearPizza myPizza = new NuclearPizza();
            myPizza.Kw = 1000;                      // It's a 1000 kilowatt pizza. That seems like a lot, but who knows?

            Console.WriteLine("Baking the pizza..."); myPizza.Bake();

            Console.WriteLine("Attempting to perform an emergency shut down on the " + myPizza.Kw + " kilowatt Pizza...");
            if (myPizza.EmergencyShutdown() == true) {
                Console.WriteLine("Shutdown succeeded");
            } else {
                Console.WriteLine("Shutdown failed");
            }

            myPizza.callSteve();
            myPizza.callSteve("hello steve. My professor keeps making simpsons references, can you come over and help.");

            HarshaDam myHarshaDam = new HarshaDam();
            CommunicateWithSteve(myHarshaDam, "dam is done");
            CommunicateWithSteve(myPizza, "the pizza is ready");
        }
        static void CommunicateWithSteve(TellSteve ts, String msg)  // programming to the interface
        {
            ts.callSteve(msg);
        }
    }
}
