using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class RoundHole
    {
        private int m_radius;

        public RoundHole(int radius)
        {
            m_radius = radius;
        }

        public int getRadius()
        {
            return m_radius;
        }

        public bool fits(RoundPeg peg)
        {
            return peg.getRadius() <= m_radius;
        }

    }
}
