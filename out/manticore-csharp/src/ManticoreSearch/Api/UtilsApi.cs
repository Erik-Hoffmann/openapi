/*
 * Manticore Search Client
 *
 * Low-level client for Manticore Search. 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@manticoresearch.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using ManticoreSearch.Client;
using ManticoreSearch.Model;

namespace ManticoreSearch.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUtilsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Perform SQL requests
        /// </summary>
        /// <remarks>
        /// Run a query in SQL format. Expects a query string passed through &#x60;body&#x60; parameter and optional &#x60;raw_response&#x60; parameter that defines a format of response. &#x60;raw_response&#x60; can be set to &#x60;False&#x60; for Select queries only, e.g., &#x60;SELECT * FROM myindex&#x60; The query string must stay as it is, no URL encoding is needed. The response object depends on the query executed. In select mode the response has same format as &#x60;/search&#x60; operation. 
        /// </remarks>
        /// <exception cref="ManticoreSearch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A query parameter string. </param>
        /// <param name="rawResponse">Optional parameter, defines a format of response. Can be set to &#x60;False&#x60; for Select only queries and set to &#x60;True&#x60; or omitted for any type of queries:  (optional, default to true)</param>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> Sql(string body, bool? rawResponse = default(bool?));

        /// <summary>
        /// Perform SQL requests
        /// </summary>
        /// <remarks>
        /// Run a query in SQL format. Expects a query string passed through &#x60;body&#x60; parameter and optional &#x60;raw_response&#x60; parameter that defines a format of response. &#x60;raw_response&#x60; can be set to &#x60;False&#x60; for Select queries only, e.g., &#x60;SELECT * FROM myindex&#x60; The query string must stay as it is, no URL encoding is needed. The response object depends on the query executed. In select mode the response has same format as &#x60;/search&#x60; operation. 
        /// </remarks>
        /// <exception cref="ManticoreSearch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A query parameter string. </param>
        /// <param name="rawResponse">Optional parameter, defines a format of response. Can be set to &#x60;False&#x60; for Select only queries and set to &#x60;True&#x60; or omitted for any type of queries:  (optional, default to true)</param>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> SqlWithHttpInfo(string body, bool? rawResponse = default(bool?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUtilsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Perform SQL requests
        /// </summary>
        /// <remarks>
        /// Run a query in SQL format. Expects a query string passed through &#x60;body&#x60; parameter and optional &#x60;raw_response&#x60; parameter that defines a format of response. &#x60;raw_response&#x60; can be set to &#x60;False&#x60; for Select queries only, e.g., &#x60;SELECT * FROM myindex&#x60; The query string must stay as it is, no URL encoding is needed. The response object depends on the query executed. In select mode the response has same format as &#x60;/search&#x60; operation. 
        /// </remarks>
        /// <exception cref="ManticoreSearch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A query parameter string. </param>
        /// <param name="rawResponse">Optional parameter, defines a format of response. Can be set to &#x60;False&#x60; for Select only queries and set to &#x60;True&#x60; or omitted for any type of queries:  (optional, default to true)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> SqlAsync(string body, bool? rawResponse = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Perform SQL requests
        /// </summary>
        /// <remarks>
        /// Run a query in SQL format. Expects a query string passed through &#x60;body&#x60; parameter and optional &#x60;raw_response&#x60; parameter that defines a format of response. &#x60;raw_response&#x60; can be set to &#x60;False&#x60; for Select queries only, e.g., &#x60;SELECT * FROM myindex&#x60; The query string must stay as it is, no URL encoding is needed. The response object depends on the query executed. In select mode the response has same format as &#x60;/search&#x60; operation. 
        /// </remarks>
        /// <exception cref="ManticoreSearch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A query parameter string. </param>
        /// <param name="rawResponse">Optional parameter, defines a format of response. Can be set to &#x60;False&#x60; for Select only queries and set to &#x60;True&#x60; or omitted for any type of queries:  (optional, default to true)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> SqlWithHttpInfoAsync(string body, bool? rawResponse = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUtilsApi : IUtilsApiSync, IUtilsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UtilsApi : IDisposable, IUtilsApi
    {
        private ManticoreSearch.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public UtilsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public UtilsApi(string basePath)
        {
            this.Configuration = ManticoreSearch.Client.Configuration.MergeConfigurations(
                ManticoreSearch.Client.GlobalConfiguration.Instance,
                new ManticoreSearch.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new ManticoreSearch.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = ManticoreSearch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilsApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public UtilsApi(ManticoreSearch.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = ManticoreSearch.Client.Configuration.MergeConfigurations(
                ManticoreSearch.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ManticoreSearch.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = ManticoreSearch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public UtilsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public UtilsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = ManticoreSearch.Client.Configuration.MergeConfigurations(
                ManticoreSearch.Client.GlobalConfiguration.Instance,
                new ManticoreSearch.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new ManticoreSearch.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = ManticoreSearch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilsApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public UtilsApi(HttpClient client, ManticoreSearch.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = ManticoreSearch.Client.Configuration.MergeConfigurations(
                ManticoreSearch.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ManticoreSearch.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = ManticoreSearch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public UtilsApi(ManticoreSearch.Client.ISynchronousClient client, ManticoreSearch.Client.IAsynchronousClient asyncClient, ManticoreSearch.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = ManticoreSearch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public ManticoreSearch.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ManticoreSearch.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ManticoreSearch.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ManticoreSearch.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ManticoreSearch.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Perform SQL requests Run a query in SQL format. Expects a query string passed through &#x60;body&#x60; parameter and optional &#x60;raw_response&#x60; parameter that defines a format of response. &#x60;raw_response&#x60; can be set to &#x60;False&#x60; for Select queries only, e.g., &#x60;SELECT * FROM myindex&#x60; The query string must stay as it is, no URL encoding is needed. The response object depends on the query executed. In select mode the response has same format as &#x60;/search&#x60; operation. 
        /// </summary>
        /// <exception cref="ManticoreSearch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A query parameter string. </param>
        /// <param name="rawResponse">Optional parameter, defines a format of response. Can be set to &#x60;False&#x60; for Select only queries and set to &#x60;True&#x60; or omitted for any type of queries:  (optional, default to true)</param>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> Sql(string body, bool? rawResponse = default(bool?))
        {
            ManticoreSearch.Client.ApiResponse<List<Object>> localVarResponse = SqlWithHttpInfo(body, rawResponse);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Perform SQL requests Run a query in SQL format. Expects a query string passed through &#x60;body&#x60; parameter and optional &#x60;raw_response&#x60; parameter that defines a format of response. &#x60;raw_response&#x60; can be set to &#x60;False&#x60; for Select queries only, e.g., &#x60;SELECT * FROM myindex&#x60; The query string must stay as it is, no URL encoding is needed. The response object depends on the query executed. In select mode the response has same format as &#x60;/search&#x60; operation. 
        /// </summary>
        /// <exception cref="ManticoreSearch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A query parameter string. </param>
        /// <param name="rawResponse">Optional parameter, defines a format of response. Can be set to &#x60;False&#x60; for Select only queries and set to &#x60;True&#x60; or omitted for any type of queries:  (optional, default to true)</param>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ManticoreSearch.Client.ApiResponse<List<Object>> SqlWithHttpInfo(string body, bool? rawResponse = default(bool?))
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ManticoreSearch.Client.ApiException(400, "Missing required parameter 'body' when calling UtilsApi->Sql");

            ManticoreSearch.Client.RequestOptions localVarRequestOptions = new ManticoreSearch.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "text/plain"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ManticoreSearch.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ManticoreSearch.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (rawResponse != null)
            {
                localVarRequestOptions.QueryParameters.Add(ManticoreSearch.Client.ClientUtils.ParameterToMultiMap("", "raw_response", rawResponse));
            }
            localVarRequestOptions.Data = body;


            // make the HTTP request
            var localVarResponse = this.Client.Post<List<Object>>("/sql", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Sql", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Perform SQL requests Run a query in SQL format. Expects a query string passed through &#x60;body&#x60; parameter and optional &#x60;raw_response&#x60; parameter that defines a format of response. &#x60;raw_response&#x60; can be set to &#x60;False&#x60; for Select queries only, e.g., &#x60;SELECT * FROM myindex&#x60; The query string must stay as it is, no URL encoding is needed. The response object depends on the query executed. In select mode the response has same format as &#x60;/search&#x60; operation. 
        /// </summary>
        /// <exception cref="ManticoreSearch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A query parameter string. </param>
        /// <param name="rawResponse">Optional parameter, defines a format of response. Can be set to &#x60;False&#x60; for Select only queries and set to &#x60;True&#x60; or omitted for any type of queries:  (optional, default to true)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> SqlAsync(string body, bool? rawResponse = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ManticoreSearch.Client.ApiResponse<List<Object>> localVarResponse = await SqlWithHttpInfoAsync(body, rawResponse, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Perform SQL requests Run a query in SQL format. Expects a query string passed through &#x60;body&#x60; parameter and optional &#x60;raw_response&#x60; parameter that defines a format of response. &#x60;raw_response&#x60; can be set to &#x60;False&#x60; for Select queries only, e.g., &#x60;SELECT * FROM myindex&#x60; The query string must stay as it is, no URL encoding is needed. The response object depends on the query executed. In select mode the response has same format as &#x60;/search&#x60; operation. 
        /// </summary>
        /// <exception cref="ManticoreSearch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A query parameter string. </param>
        /// <param name="rawResponse">Optional parameter, defines a format of response. Can be set to &#x60;False&#x60; for Select only queries and set to &#x60;True&#x60; or omitted for any type of queries:  (optional, default to true)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ManticoreSearch.Client.ApiResponse<List<Object>>> SqlWithHttpInfoAsync(string body, bool? rawResponse = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ManticoreSearch.Client.ApiException(400, "Missing required parameter 'body' when calling UtilsApi->Sql");


            ManticoreSearch.Client.RequestOptions localVarRequestOptions = new ManticoreSearch.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "text/plain"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = ManticoreSearch.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ManticoreSearch.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (rawResponse != null)
            {
                localVarRequestOptions.QueryParameters.Add(ManticoreSearch.Client.ClientUtils.ParameterToMultiMap("", "raw_response", rawResponse));
            }
            localVarRequestOptions.Data = body;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<List<Object>>("/sql", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Sql", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
