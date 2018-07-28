using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentNotationTest
{
    public static class X
    {
        public static void With<T>(T obj, params Action<T>[] actions)
        {
        }
    }
}
