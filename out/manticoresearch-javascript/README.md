# manticore_search_client

ManticoreSearchClient - JavaScript client for manticore_search_client
Please note that this client is experimental.
For full documentation of the API methods consult https://manual.manticoresearch.com/.

This SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- Package version: 1.0.0
- Build package: org.openapitools.codegen.languages.JavascriptClientCodegen
For more information, please visit [https://manticoresearch.com/contact-us/](https://manticoresearch.com/contact-us/)

## Installation

### For [Node.js](https://nodejs.org/)

#### npm

To publish the library as a [npm](https://www.npmjs.com/), please follow the procedure in ["Publishing npm packages"](https://docs.npmjs.com/getting-started/publishing-npm-packages).

Then install it via:

```shell
npm install manticore_search_client --save
```

##### Local development

To use the library locally without publishing to a remote npm registry, first install the dependencies by changing into the directory containing `package.json` (and this README). Let's call this `JAVASCRIPT_CLIENT_DIR`. Then run:

```shell
npm install
```

Next, [link](https://docs.npmjs.com/cli/link) it globally in npm with the following, also from `JAVASCRIPT_CLIENT_DIR`:

```shell
npm link
```

Finally, switch to the directory you want to use your manticore_search_client from, and run:

```shell
npm link /path/to/<JAVASCRIPT_CLIENT_DIR>
```

You should now be able to `require('manticore_search_client')` in javascript files from the directory you ran the last command above from.

### git

If the library is hosted at a git repository, e.g. https://github.com/manticoresoftware/manticoresearch-javascript
then install it via:

```shell
    npm install manticoresoftware/manticoresearch-javascript --save
```

### For browser

The library also works in the browser environment via npm and [browserify](http://browserify.org/). After following the above steps with Node.js and installing browserify with `npm install -g browserify`, perform the following (assuming *main.js* is your entry file, that's to say your javascript file where you actually use this library):

```shell
browserify main.js > bundle.js
```

Then include *bundle.js* in the HTML pages.

### Webpack Configuration

Using Webpack you may encounter the following error: "Module not found: Error:
Cannot resolve module", most certainly you should disable AMD loader. Add/merge
the following section to your webpack config:

```javascript
module: {
  rules: [
    {
      parser: {
        amd: false
      }
    }
  ]
}
```

## Getting Started

Please follow the [installation](#installation) instruction and execute the following JS code:

```javascript
var ManticoreSearchClient = require('manticore_search_client');


var api = new ManticoreSearchClient.IndexApi()
var body = "body_example"; // {String} 

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.bulk(body, callback);

```

## Documentation for API Endpoints

All URIs are relative to *http://127.0.0.1:9308*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ManticoreSearchClient.IndexApi* | [**bulk**](docs/IndexApi.md#bulk) | **POST** /json/bulk | Bulk index operations
*ManticoreSearchClient.IndexApi* | [**callDelete**](docs/IndexApi.md#callDelete) | **POST** /json/delete | Delete a document in an index
*ManticoreSearchClient.IndexApi* | [**insert**](docs/IndexApi.md#insert) | **POST** /json/insert | Create a new document in an index
*ManticoreSearchClient.IndexApi* | [**replace**](docs/IndexApi.md#replace) | **POST** /json/replace | Replace new document in an index
*ManticoreSearchClient.IndexApi* | [**update**](docs/IndexApi.md#update) | **POST** /json/update | Update a document in an index
*ManticoreSearchClient.SearchApi* | [**percolate**](docs/SearchApi.md#percolate) | **POST** /json/pq/{index}/search | Perform reverse search on a percolate index
*ManticoreSearchClient.SearchApi* | [**search**](docs/SearchApi.md#search) | **POST** /json/search | Performs a search
*ManticoreSearchClient.UtilsApi* | [**sql**](docs/UtilsApi.md#sql) | **POST** /sql | Perform SQL requests


## Documentation for Models

 - [ManticoreSearchClient.BulkResponse](docs/BulkResponse.md)
 - [ManticoreSearchClient.DeleteDocumentRequest](docs/DeleteDocumentRequest.md)
 - [ManticoreSearchClient.DeleteResponse](docs/DeleteResponse.md)
 - [ManticoreSearchClient.ErrorResponse](docs/ErrorResponse.md)
 - [ManticoreSearchClient.InsertDocumentRequest](docs/InsertDocumentRequest.md)
 - [ManticoreSearchClient.PercolateRequest](docs/PercolateRequest.md)
 - [ManticoreSearchClient.SearchRequest](docs/SearchRequest.md)
 - [ManticoreSearchClient.SearchResponse](docs/SearchResponse.md)
 - [ManticoreSearchClient.SearchResponseHits](docs/SearchResponseHits.md)
 - [ManticoreSearchClient.SuccessResponse](docs/SuccessResponse.md)
 - [ManticoreSearchClient.UpdateDocumentRequest](docs/UpdateDocumentRequest.md)
 - [ManticoreSearchClient.UpdateResponse](docs/UpdateResponse.md)


## Documentation for Authorization

All endpoints do not require authorization.