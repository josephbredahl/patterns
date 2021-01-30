using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class SquarePegClassAdapter : RoundPeg
    {
        private SquarePeg m_peg;

        public SquarePegClassAdapter(SquarePeg peg)
        {
            m_peg = peg;
        }

        public override double getRadius()
        {
            return m_peg.getWidth() * Math.Sqrt(2) / 2;
        }
    }
}
