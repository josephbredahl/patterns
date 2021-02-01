using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class SquarePegInterfaceAdapter : IRoundPeg
    {
        private SquarePeg m_peg;

        public SquarePegInterfaceAdapter(SquarePeg peg)
        {
            m_peg = peg;
        }
        public double getRadius()
        {
            return m_peg.getWidth() * Math.Sqrt(2) / 2;
        }
    }
}
