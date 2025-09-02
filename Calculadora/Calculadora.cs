using System.Collections.Generic;
using System;

namespace Calculadora
{
    public class Calculadora
    {
        private List<string> _historico;

        public Calculadora()
        {
            _historico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            AdicionarAoHistorico($"{num1} + {num2} = {resultado}");
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            AdicionarAoHistorico($"{num1} - {num2} = {resultado}");
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            AdicionarAoHistorico($"{num1} * {num2} = {resultado}");
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Não é possível dividir por zero.", nameof(num2));
            }
            int resultado = num1 / num2;
            AdicionarAoHistorico($"{num1} / {num2} = {resultado}");
            return resultado;
        }

        public List<string> Historico()
        {
            return _historico;
        }

        private void AdicionarAoHistorico(string operacao)
        {
            _historico.Insert(0, operacao);
            if (_historico.Count > 3)
            {
                _historico.RemoveRange(3, _historico.Count - 3);
            }
        }
    }
}
