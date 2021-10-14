using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearPizza
{
    interface TellSteve
    {
        /// <summary>
        /// Call steve with a default message that things are not going well at the plant.
        /// </summary>
        void callSteve();
        /// <summary>
        /// Call steve with your very own cutom message to tell him we are all about to die.
        /// </summary>
        /// <param name="msg">The message you are sending to steve.</param>
        void callSteve(String msg);
    }
}
