'use strict'

const mongoose = require('mongoose')

var ProdutoSchema = new mongoose.Schema({
    nome: String,
    estoque: Number
})

module.exports = mongoose.model('produtos', ProdutoSchema)