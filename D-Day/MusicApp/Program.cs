using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new MusicApp();
            s.Play();
            s.Play();

            s.Next();
            s.Previous();

            s.Filter("2");
            s.Play();
            s.Filter(" ");
            s.Play();
        }
    }
}
