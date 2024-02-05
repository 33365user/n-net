using n_net_poker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nn2
{
    internal class main
    {
        static void Main(string[] args)
        {

            //used to test the feed forward capabilities
            int layers = 5;
            int indexes_per_layer = 10;


            utils u = new utils();
            neuralNetwork new_n = new neuralNetwork(layers, indexes_per_layer);

            for(int a = 0; a < layers; a++)
            {
                for (int b = 0; b < indexes_per_layer; b++)
                {
                    node dummy = new node(u.returnRandomDouble(10), u.returnRandomDouble(10), u.returnRandomDouble(10));

                    new_n.addNode(a, b, dummy);
                }
            }

            new_n.printNetwork();

            new_n.feedForward();

            new_n.printNetwork();

            Console.ReadLine();
        }
    }
}
