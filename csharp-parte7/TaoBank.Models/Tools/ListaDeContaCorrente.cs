
using System;

namespace TaoBank.Models.Tools {
    public class ListaDeContaCorrente {
        private ContaCorrente[] _itens;
        private int _proxPosicao;

        public ListaDeContaCorrente(int capacidadeInicial = 10) {
            _itens = new ContaCorrente[capacidadeInicial];
            _proxPosicao = 0;
        }

        public void EscreverListaNaTela() {
            for(int i = 0; i < _proxPosicao; i++) {
                ContaCorrente conta = _itens[i];
                System.Console.WriteLine($"Pos[{i}] - AG: {conta.Agencia} . CC: {conta.Numero}");
            }
        }

        public void Adicionar(ContaCorrente item) {
            VerificaCapacidade(_proxPosicao);
            System.Console.WriteLine($"Adicionando item na posição [{_proxPosicao}]");
            _itens[_proxPosicao] = item;
            _proxPosicao++;
        }

        public void AdicionarVarios(params ContaCorrente[] itens) {
            foreach(ContaCorrente conta in itens) {
                Adicionar(conta);
            }
        }

        public ContaCorrente GetContaCorrenteIndice(int indice) {

            if (indice < 0 || indice >= _proxPosicao) {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }

        public void Remover(ContaCorrente item) {
            int indiceItem = 0;

            for (int i = 0; i < _proxPosicao; i++) {
                ContaCorrente itemAtual = _itens[i];

                if (itemAtual.Equals(item)) {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proxPosicao-1; i++) {
                _itens[i] = _itens[i + 1];
            }

            _proxPosicao--;
            _itens[_proxPosicao] = null;
        }

        public ContaCorrente this[int indice] {
            get {
                return GetContaCorrenteIndice(indice);
            }
        }

        private void VerificaCapacidade(int tamanhoNecessario) {
            if (_itens.Length > tamanhoNecessario) {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario) {
                novoTamanho = tamanhoNecessario;
            }

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++) {
                novoArray[indice] = _itens[indice];
            }

            _itens = novoArray;
        }



    }
}
