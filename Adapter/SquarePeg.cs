using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class SquarePeg
    {
        private int m_width;

        public SquarePeg(int width)
        {
            m_width = width;
        }

        public int getWidth()
        {
            return m_width;
        }
    }
}
