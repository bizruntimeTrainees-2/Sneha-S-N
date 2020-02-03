using System.Net;

namespace ConsoleApp1
{
    internal class IDEndPoint : EndPoint
    {
        private int v1;
        private int v2;

        public IDEndPoint(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}