using Applications.Interface;
using Domain.Entidades;
using Domain.Interfaces.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Applications.Aplicacoes
{
    public class AppProduto : InterfaceAppProduto
    {

        InterfaceProduto _InterfaceProduto;

        public AppProduto(InterfaceProduto InterfaceProduto)
        {
            _InterfaceProduto = InterfaceProduto;
        }

        public void Adcionar(Produto Objeto)
        {
            _InterfaceProduto.Adcionar(Objeto);
        }

        public void Atualizar(Produto Objeto)
        {
            _InterfaceProduto.Atualizar(Objeto);
        }

        public void Excluir(Produto Objeto)
        {
            _InterfaceProduto.Excluir(Objeto);
        }

        public IList<Produto> Listar()
        {
            return _InterfaceProduto.Listar();
        }

        public Produto ObterPorId(int Id)
        {
            return _InterfaceProduto.ObterPorId(Id);
        }
    }
}
