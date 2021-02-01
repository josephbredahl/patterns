using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var hole = new RoundHole(5);
            var rpeg = new RoundPeg(5);
            Console.WriteLine("Hole Fits: " + hole.fits(rpeg));

            var small_sqpeg = new SquarePeg(5);
            var large_sqpeg = new SquarePeg(10);
            // The next line wont compile
            // Console.WriteLine("Hole Fits" + hole.fits(small_sqpeg));

            var small_sqpeg_class_adapter = new SquarePegClassAdapter(small_sqpeg);
            var large_sqpeg_class_adapter = new SquarePegClassAdapter(large_sqpeg);
            var small_sqpeg_Interface_adapter = new SquarePegInterfaceAdapter(small_sqpeg);
            var large_sqpeg_Interface_adapter = new SquarePegInterfaceAdapter(large_sqpeg);
            Console.WriteLine("Hole Fits: " + hole.fits(small_sqpeg_class_adapter));
            Console.WriteLine("Hole Fits: " + hole.fits(large_sqpeg_class_adapter));
            Console.WriteLine("Hole Fits: " + hole.fits(small_sqpeg_Interface_adapter));
            Console.WriteLine("Hole Fits: " + hole.fits(large_sqpeg_Interface_adapter));
        }
    }
}
