using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMMERING_2_KURSPROV
{
    internal class Quadrupler : Doubler
    {
        public int ExecuteQuadrupling()
        {
            ExecuteDoubling;
            return ExecuteDoubling;

        }

        public int QuadruplingExecutions
        {
            get { return DoublingEx / 2; }
        }
            
        public Quadrupler(int InputValue) : base(InputValue)
        {

        }
 
    }
}
