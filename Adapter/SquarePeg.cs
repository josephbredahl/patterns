using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class SquarePeg
    {
        private double m_width;

        public SquarePeg(double width)
        {
            m_width = width;
        }

        public double getWidth()
        {
            return m_width;
        }
    }
}
