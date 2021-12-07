﻿using System.Collections;
using System.Collections.ObjectModel;


var neuron1 = new Neuron();
var neuron2 = new Neuron();
var layer1 = new NeuronLayer(3);
var layer2 = new NeuronLayer(4);

neuron1.ConnectTo(neuron2); // works already :)
neuron1.ConnectTo(layer1);
layer2.ConnectTo(neuron1);
layer1.ConnectTo(layer2);




public class Neuron : IEnumerable<Neuron>
{
    public List<Neuron> Entrada, Salida;
    public IEnumerator<Neuron> GetEnumerator()
    {
        yield return this;
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


public class NeuronLayer : Collection<Neuron>
{
    public NeuronLayer(int conteo)
    {
        while (conteo-- > 0) { Add(new Neuron()); }
    }
}


public static class ExtensionMethods
{
    public static void ConnectTo
        (
        this IEnumerable<Neuron> self,
        IEnumerable<Neuron> other
        )
    {
        if (ReferenceEquals(self, other)) { return; }

        foreach (var from in self)
        {
            foreach (var to in other)
            {
                from.Salida.Add(to);
                to.Entrada.Add(from);
            }
        }
    }
}