using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMMERING_2_KURSPROV
{
    internal class Doubler
    {
        private int _value;
        private int _doublingExecutions;

        public int DoublingExecutions
        {
            get { return _doublingExecutions; }
        }

        public void ExecuteDoubling()
        {
            _value *= 2;
            _doublingExecutions += 1;
        }

        public string GetString()
        {
            string Value = int.Parse(_value);
            string doublingExecutions = int.Parse(_doublingExecutions);
            return _value + " " + _doublingExecutions;
        }

        public int DoublingEx
        {
            get { return _doublingExecutions; }
        }

        public Doubler(int InputValue)
        {
            _value = InputValue;

        }
    }
}
