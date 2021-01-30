using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class RoundPeg
    {
        private double m_radius;

        public RoundPeg() : this(0) { }
        public RoundPeg(double radius)
        {
            m_radius = radius;
        }

        public virtual double getRadius()
        {
            return m_radius;
        }
    }
}
