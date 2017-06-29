'use strict';

const mongoose = require('mongoose')

var InscricaoSchema = new mongoose.Schema({
    idTopico: {
        type: String,
        required: true
    },
    url: {
        type: String,
        required: true
    }
})

InscricaoSchema.index({ idTopico: 1, url: 1 }, { unique: true })

module.exports = mongoose.model('incricao', InscricaoSchema);