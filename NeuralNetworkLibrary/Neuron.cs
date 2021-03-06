﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkLibrary
{
    public abstract class Neuron
    {
        public Neuron(string id)
        {
            ID = id;
        }

        public string ID { get; }

        // public abstract float Bias { get; set; }

        public bool IsBiased { get; set; } = false;

        public float Activation { get; set; }

        /// <summary>
        /// Gets or sets the connections. Where a connection represents the connection between
        /// weights from this neuron to the neuron in next layer.
        /// </summary>
        /// <value>The connections.</value>
        public List<Connection> Connections { get; set; } = new List<Connection>();

        public void AddConnection(Neuron neuron, float weight)
        {
            if (Connections.Find(x => x.NeuronFrom == neuron) == null) // couldn't find
            {
                Connections.Add(new Connection(neuron, weight));
            }
        }

        public void ClearConnections()
        {
            Connections = new List<Connection>();
        }
    }
}