using System;
using System.Collections.Generic;
using System.Text;

namespace Neuron
{
    public class InputLayer
    {
        private (double[], double[])[] _trainset = new (double[], double[])[]
        {
            (new double[]{ 0, 0 }, new double[]{ 0, 1 }),
            (new double[]{ 0, 1 }, new double[]{ 1, 0 }),
            (new double[]{ 1, 0 }, new double[]{ 1, 0 }),
            (new double[]{ 1, 1 }, new double[]{ 0, 1 })
        };
        
        public (double[], double[])[] Trainset { get => _trainset; }
    }
}
