using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class RoundPeg
    {
        private int m_radius;

        public RoundPeg() : this(0) { }
        public RoundPeg(int radius)
        {
            m_radius = radius;
        }

        public int getRadius()
        {
            return m_radius;
        }
    }
}
