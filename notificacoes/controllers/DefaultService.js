'use strict';

const request = require('request')
const Inscricao = require('./../models/inscricao')

exports.apiNotificacoesV1IdTopicoPOST = function (args, res, next) {
    /**
     * cria uma notificação
     *
     * idTopico String identificação do topico da notificação
     * conteudo Conteudo conteudo da notificação (optional)
     * no response value expected for this operation
     **/
    Inscricao.find({ idTopico: args.idTopico.value })
        .exec()
        .then(list => {
            // dados a serem enviados
            var payload = querystring.stringify(args.conteudo.value)
            list.forEach((incricao, idx) => {
                //request
                //    .post(incricao.url)
                //    .form(payload)
            })
        })

    res.statusCode = 204;
    res.end();
}

exports.apiNotificacoesV1IdTopicoSubscribePOST = function (args, res, next) {
    /**
     * registra que algo que ser notificado quando este topico receber informações
     *
     * idTopico String identificação do topico da notificação
     * subscription Subscription onde esta (optional)
     * no response value expected for this operation
     **/
    var nova = new Inscricao({
        idTopico: args.idTopico.value,
        url: args.subscription.value.url
    });
    nova.save()
        .then(incricao => {
            res.statusCode = 204;
            res.end();
        })
        .catch(e => {
            res.statusCode = 500;
            res.end(e);
        })
}

