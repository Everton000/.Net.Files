﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void EscritaBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456); // Número da Agência
            escritor.Write(5656565); // Número da conta
            escritor.Write(4000.50); // Saldo
            escritor.Write("Gustavo Braga");
        }
    }

    static void LeituraBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
        using (var leitor = new BinaryReader(fs))
        {
            var agencia = leitor.ReadInt32();
            var numeroConta = leitor.ReadInt32();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();

            Console.WriteLine($"Agência: {agencia}, Número da conta: {numeroConta}, Saldo: {saldo}, Titular: {titular}");
        }
    }
}
