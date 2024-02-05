using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn2
{
    internal class neuralNetwork
    {
        // Private fields to store the number of layers, nodes per layer, and the neural network structure
        private int layers;
        private int nodes_per_layer;
        public node[,] network;

        // Constructor to initialize the neural network with the specified number of layers and nodes per layer
        public neuralNetwork(int user_layers, int user_nodes_per_layer)
        {
            this.layers = user_layers;
            this.nodes_per_layer = user_nodes_per_layer;
            this.network = new node[layers, nodes_per_layer];
        }

        // Method to perform feedforward propagation in the neural network
        public node[,] feedForward()
        {
            node[,] fed_network = new node[layers, nodes_per_layer];

            // Loop through each layer and node in the network
            for (int a = 0; a < this.layers; a++)
            {
                //At each node on the current layer
                for (int b = 0; b < this.nodes_per_layer; b++)
                {
                    //Calculate the modified value using node's main value and weight
                    double modified_value = (this.network[a, b].getMainValue() * this.network[a, b].getWeight());

                    // Loop through nodes in the layer to modify the value based on weights
                    for (int c = 0; c < this.nodes_per_layer; c++)
                    {
                        //if the modified value is greated than the bias of the node at the index
                        if (modified_value > this.network[a, c].getBias())
                        {
                            //allow the modified value to be influenced by the weight
                            modified_value = (modified_value * this.network[a, c].getWeight());
                        }
                    }

                    // Update node value based on modified value and bias
                    if (modified_value > this.network[a, b].getBias())
                    {
                        node n = new node(modified_value, this.network[a, b].getBias(), this.network[a, b].getWeight());
                        fed_network[a, b] = n;
                    }
                    else
                    {
                        //else if the value is not great enough, do not pass on the node's values
                        node n = new node(0.0, this.network[a, b].getBias(), 1.0);
                        fed_network[a, b] = n;
                    }
                }
            }

            this.network = fed_network;

            return fed_network; // Return the modified network after feedforward
        }

        // Method to add a node at a specified position in the neural network
        public bool addNode(int target_layer, int target_place_on_layer, node node_to_add)
        {
            try
            {
                this.network[target_layer, target_place_on_layer] = node_to_add;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        // Method to remove a node from a specified position in the neural network
        public bool removeNode(int target_layer, int target_place_on_layer)
        {
            try
            {
                this.network[target_layer, target_place_on_layer] = null;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        // Method to get a node from a specified position in the neural network
        public node getNode(int target_layer, int target_place_on_layer)
        {
            try
            {
                return this.network[target_layer, target_place_on_layer];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public bool printNetwork()
        {
            try
            {
                for(int a = 0; a < this.layers; a++)
                {
                    Console.WriteLine("\n Layer " + (a + 1) +"(main value, bias, weight)"+"\n");

                    for (int b = 0; b < this.nodes_per_layer; b++)
                    {
                        Console.WriteLine(getNode(a,b).getMainValue()+", "+ getNode(a, b).getBias() + ", " + getNode(a, b).getWeight());
                    }
                }

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
