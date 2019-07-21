using System;

namespace Neuron
{
    class Program
    {
        static void Main(string[] args)
        {
            Network net = new Network();
            Network.Train(net);
            Network.Test(net);
        }
    }
}
