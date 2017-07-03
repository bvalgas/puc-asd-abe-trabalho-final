'use strict';

const Produto = require('./../models/produto')
const ProdutoDto = require('./produto-dto')

function toDto( model ) {
    return new ProdutoDto(model)
}

exports.apiProdutosV1ProdutosGET = function (args, res, next) {
    /**
     * Lista os produtos que o lojista possui
     *
     * returns List
     **/
    Produto
        .find()
        .exec()
        .then(produtos => {
            return produtos.map(toDto)
        })
        .then(produtos => {
            res.setHeader('Content-Type', 'application/json');
            res.end(JSON.stringify(produtos))
        })
        .catch(e => {
            console.log(e)
            res.statusCode = 500;
            res.end()
        })
}

exports.apiProdutosV1ProdutosPOST = function (args, res, next) {
    /**
     * cria novo produto
     *
     * produto Produto Produto (optional)
     * returns inline_response_200
     **/
    new Produto(args.produto.value)
        .save()
        .then(p => {
            return new ProdutoDto(p)
        })
        .then(dto => {
            res.setHeader('Content-Type', 'application/json');
            res.end(JSON.stringify(dto))
        })
        .catch(e => {
            console.log(e)
            res.statusCode = 500;
            res.end()
        })
}

