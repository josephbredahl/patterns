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

        new public int getRadius()
        {
            return m_peg.getWidth() * (int)Math.Sqrt(2) / 2;
        }
    }
}
