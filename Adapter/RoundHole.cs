using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class RoundHole
    {
        private double m_radius;

        public RoundHole(double radius)
        {
            m_radius = radius;
        }

        public double getRadius()
        {
            return m_radius;
        }

        public bool fits(RoundPeg peg)
        {
            return peg.getRadius() <= m_radius;
        }

    }
}
