﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemBeauty.Models;
using SystemBeauty.Repositories.Interfaces;
using SystemBeauty.Services.Interfaces;
using SystemBeauty.ViewModels;

namespace SystemBeauty.Services
{
    public class ProdutoServices : IProdutoService
    {
        private readonly IProdutoRP _produtoRepository;
        private readonly ICategoriaRP _categoriaRepository;

        public ProdutoServices(IProdutoRP produtoRepository, ICategoriaRP categoriaRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }

        public Produto AddProduto(Produto produto)
        {
            return _produtoRepository.AddProduto(produto);
        }
        public Produto UpdateProduto(Produto produto)
        {
            return _produtoRepository.UpdateProduto(produto);
        }

        public Produto GetProdutoById(int ID)
        {
            return _produtoRepository.GetProdutoById(ID);
        }

        public IEnumerable<Categoria> ListaCategorias()
        {
            return _categoriaRepository.ListaCategorias();
        }
        public IEnumerable<Produto> ProdutoPorCategoria(int ID)
        {
            return _produtoRepository.ProdutoPorCategoria(ID);
        }
        public IEnumerable<Produto> ListaMaisVendidos()
        {
            return _produtoRepository.ListaMaisVendidos();
        }
        public IEnumerable<Produto> ListaProduto()
        {
            return _produtoRepository.ListaProdutos();
        }

        public IEnumerable<Produto> ListaBusca(string search)
        {
            return _produtoRepository.Busca(search);
        }
    }
}
