'use strict'

module.exports = dto

function dto( model ) {
    this._links = {
        self: "http://localhost/api/produtos/v1/produtos/" + model.id
    }
    this.id = model.id
    this.nome = model.nome
    this.estoque = model.estoque
}