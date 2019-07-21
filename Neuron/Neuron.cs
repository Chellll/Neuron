using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;
using static System.Console;

namespace Neuron
{

    public enum MemoryMode { GET, SET }
    public enum NeuronType { Hidden, Output }

    public class Neuron
    {
        public Neuron(double[] inputs, double[] weights, NeuronType type)
        {
            _type = type;//тип
            _weights = weights;//вес
            _inputs = inputs;//вход
        }
        private NeuronType _type;
        private double[] _weights;
        private double[] _inputs;
        public double[] Weights { get => _weights; set => _weights = value; }
        public double[] Inputs { get => _inputs; set => _inputs = value; }
        public double Output { get => Activator(_inputs, _weights); }
        private double Activator(double[] i, double[] w)//преобразования
        {
            double sum = 0;
            for (int l = 0; l < i.Length; ++l)
                sum += i[l] * w[l];
            return Pow(1 + Exp(-sum), -1);
        }
        public double Derivativator(double outsignal) => outsignal * (1 - outsignal);//формула производной
        public double Gradientor(double error, double dif, double g_sum) => (_type == NeuronType.Output) ? error * dif : g_sum * dif;//g_sum - это сумма градиентов следующего слоя
    }
}
