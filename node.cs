using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn2
{
    internal class node
    {
        // Private fields to store the main value, bias, and weight of the node
        private double main_value;
        private double bias;
        private double weight;

        // Constructor to initialize the node with user-provided values
        public node(double user_value, double user_bias, double user_weight)
        {
            main_value = user_value;
            bias = user_bias;
            weight = user_weight;
        }

        // Getter method to retrieve the main value of the node
        public double getMainValue()
        {
            return main_value;
        }

        // Getter method to retrieve the bias of the node
        public double getBias()
        {
            return bias;
        }

        // Getter method to retrieve the weight of the node
        public double getWeight()
        {
            return weight;
        }

        // Setter method to set the main value of the node
        public void setMainValue(double input)
        {
            main_value = input;
        }

        // Setter method to set the bias of the node
        public void setBias(double input)
        {
            bias = input;
        }

        // Setter method to set the weight of the node
        public void setWeight(double input)
        {
            weight = input;
        }
    }
}
