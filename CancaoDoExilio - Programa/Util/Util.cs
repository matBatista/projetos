using System;

namespace Util
{
    public static class Util
    {
        public static string GerarTexto()
        {
            return new Random().Next().ToString();
        }
    }
}
