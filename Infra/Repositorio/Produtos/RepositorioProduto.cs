using Domain.Entidades;
using Domain.Interfaces.Produtos;
using Infra.Repositorio.Generico;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio.Produtos
{
    public class RepositorioProduto : RepositorioGenerico<Produto>, InterfaceProduto
    {
    }
}
