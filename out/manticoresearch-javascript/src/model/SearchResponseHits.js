/**
 * Manticore Search Client
 * Please note that this client is experimental. For full documentation of the API methods consult https://manual.manticoresearch.com/. 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@manticoresearch.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 *
 * OpenAPI Generator version: 5.0.0-SNAPSHOT
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.ManticoreSearchClient) {
      root.ManticoreSearchClient = {};
    }
    root.ManticoreSearchClient.SearchResponseHits = factory(root.ManticoreSearchClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';



  /**
   * The SearchResponseHits model module.
   * @module model/SearchResponseHits
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>SearchResponseHits</code>.
   * @alias module:model/SearchResponseHits
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>SearchResponseHits</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/SearchResponseHits} obj Optional instance to populate.
   * @return {module:model/SearchResponseHits} The populated <code>SearchResponseHits</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('total')) {
        obj['total'] = ApiClient.convertToType(data['total'], 'Number');
      }
      if (data.hasOwnProperty('hits')) {
        obj['hits'] = ApiClient.convertToType(data['hits'], [Object]);
      }
    }
    return obj;
  }

  /**
   * @member {Number} total
   */
  exports.prototype['total'] = undefined;
  /**
   * @member {Array.<Object>} hits
   */
  exports.prototype['hits'] = undefined;



  return exports;
}));


