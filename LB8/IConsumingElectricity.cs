using System;
using System.Collections.Generic;
using System.Text;

namespace LB8
{
    interface IConsumingElectricity
    {

        double Voltage { get; }
        double Amperage { get; }
        void ConnectToTheNetwork();
        void DisconnectFromTheNetwork();
        double DetermineCostsEnergy();


    }
}
