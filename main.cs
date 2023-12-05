using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn2
{
    internal class main
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            neuralNetwork test_network = new neuralNetwork(5, 10);

            for (int layers = 0; layers < 5; layers++)
            {
                for (int index = 0; index < 10; index++)
                {
                    node n = new node(rand.NextDouble(), rand.NextDouble(), rand.NextDouble());

                    test_network.addNode(layers, index, n);
                }
            }
        }
    }
}
