'use strict';

var url = require('url');

var Default = require('./DefaultService');

module.exports.apiProdutosV1ProdutosGET = function apiProdutosV1ProdutosGET (req, res, next) {
  Default.apiProdutosV1ProdutosGET(req.swagger.params, res, next);
};

module.exports.apiProdutosV1ProdutosPOST = function apiProdutosV1ProdutosPOST (req, res, next) {
  Default.apiProdutosV1ProdutosPOST(req.swagger.params, res, next);
};
