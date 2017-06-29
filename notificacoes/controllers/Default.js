'use strict';

var url = require('url');

var Default = require('./DefaultService');

module.exports.apiNotificacoesV1IdTopicoPOST = function apiNotificacoesV1IdTopicoPOST (req, res, next) {
  Default.apiNotificacoesV1IdTopicoPOST(req.swagger.params, res, next);
};

module.exports.apiNotificacoesV1IdTopicoSubscribePOST = function apiNotificacoesV1IdTopicoSubscribePOST (req, res, next) {
  Default.apiNotificacoesV1IdTopicoSubscribePOST(req.swagger.params, res, next);
};
