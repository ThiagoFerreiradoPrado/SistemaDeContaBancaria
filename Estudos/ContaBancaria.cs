﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course {
    class ContaBancaria {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }
        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public void Saque(double quantia) {
            Saldo -= quantia + 5.0 ;
       
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Deposito(depositoInicial);
        }
        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
            
        }

















    }
}











