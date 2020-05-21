/**
 * Manticore Search API
 * This is the API for Manticore Search HTTP protocol 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: adrian.nuta@manticoresearch.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

import ApiClient from '../ApiClient';

/**
 * The DeleteDocumentRequest model module.
 * @module model/DeleteDocumentRequest
 * @version 1.0.0
 */
class DeleteDocumentRequest {
    /**
     * Constructs a new <code>DeleteDocumentRequest</code>.
     * @alias module:model/DeleteDocumentRequest
     * @param index {String} 
     */
    constructor(index) { 
        
        DeleteDocumentRequest.initialize(this, index);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj, index) { 
        obj['index'] = index;
    }

    /**
     * Constructs a <code>DeleteDocumentRequest</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/DeleteDocumentRequest} obj Optional instance to populate.
     * @return {module:model/DeleteDocumentRequest} The populated <code>DeleteDocumentRequest</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new DeleteDocumentRequest();

            if (data.hasOwnProperty('index')) {
                obj['index'] = ApiClient.convertToType(data['index'], 'String');
            }
            if (data.hasOwnProperty('id')) {
                obj['id'] = ApiClient.convertToType(data['id'], 'Number');
            }
            if (data.hasOwnProperty('doc')) {
                obj['doc'] = ApiClient.convertToType(data['doc'], Object);
            }
        }
        return obj;
    }


}

/**
 * @member {String} index
 */
DeleteDocumentRequest.prototype['index'] = undefined;

/**
 * @member {Number} id
 */
DeleteDocumentRequest.prototype['id'] = undefined;

/**
 * @member {Object} doc
 */
DeleteDocumentRequest.prototype['doc'] = undefined;






export default DeleteDocumentRequest;

