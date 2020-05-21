=begin comment

Manticore Search API

This is the API for Manticore Search HTTP protocol 

The version of the OpenAPI document: 1.0.0
Contact: adrian.nuta@manticoresearch.com
Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# Do not edit the class manually.
# Ref: https://openapi-generator.tech
#
package WWW::OpenAPIClient::IndexApi;

require 5.6.0;
use strict;
use warnings;
use utf8; 
use Exporter;
use Carp qw( croak );
use Log::Any qw($log);

use WWW::OpenAPIClient::ApiClient;

use base "Class::Data::Inheritable";

__PACKAGE__->mk_classdata('method_documentation' => {});

sub new {
    my $class = shift;
    my $api_client;

    if ($_[0] && ref $_[0] && ref $_[0] eq 'WWW::OpenAPIClient::ApiClient' ) {
        $api_client = $_[0];
    } else {
        $api_client = WWW::OpenAPIClient::ApiClient->new(@_);
    }

    bless { api_client => $api_client }, $class;

}


#
# delete
#
# Delete a document in an index
# 
# @param DeleteDocumentRequest $delete_document_request  (required)
{
    my $params = {
    'delete_document_request' => {
        data_type => 'DeleteDocumentRequest',
        description => '',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'delete' } = { 
        summary => 'Delete a document in an index',
        params => $params,
        returns => 'SuccessResponse',
        };
}
# @return SuccessResponse
#
sub delete {
    my ($self, %args) = @_;

    # verify the required parameter 'delete_document_request' is set
    unless (exists $args{'delete_document_request'}) {
      croak("Missing the required parameter 'delete_document_request' when calling delete");
    }

    # parse inputs
    my $_resource_path = '/json/delete';

    my $_method = 'POST';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept('application/json');
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type('application/json');

    my $_body_data;
    # body params
    if ( exists $args{'delete_document_request'}) {
        $_body_data = $args{'delete_document_request'};
    }

    # authentication setting, if any
    my $auth_settings = [qw()];

    # make the API Call
    my $response = $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    if (!$response) {
        return;
    }
    my $_response_object = $self->{api_client}->deserialize('SuccessResponse', $response);
    return $_response_object;
}

#
# insert
#
# Create a new document in an index
# 
# @param InsertDocumentRequest $insert_document_request  (required)
{
    my $params = {
    'insert_document_request' => {
        data_type => 'InsertDocumentRequest',
        description => '',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'insert' } = { 
        summary => 'Create a new document in an index',
        params => $params,
        returns => 'SuccessResponse',
        };
}
# @return SuccessResponse
#
sub insert {
    my ($self, %args) = @_;

    # verify the required parameter 'insert_document_request' is set
    unless (exists $args{'insert_document_request'}) {
      croak("Missing the required parameter 'insert_document_request' when calling insert");
    }

    # parse inputs
    my $_resource_path = '/json/insert';

    my $_method = 'POST';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept('application/json');
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type('application/json');

    my $_body_data;
    # body params
    if ( exists $args{'insert_document_request'}) {
        $_body_data = $args{'insert_document_request'};
    }

    # authentication setting, if any
    my $auth_settings = [qw()];

    # make the API Call
    my $response = $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    if (!$response) {
        return;
    }
    my $_response_object = $self->{api_client}->deserialize('SuccessResponse', $response);
    return $_response_object;
}

#
# replace
#
# Replace new document in an index
# 
# @param InsertDocumentRequest $insert_document_request  (required)
{
    my $params = {
    'insert_document_request' => {
        data_type => 'InsertDocumentRequest',
        description => '',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'replace' } = { 
        summary => 'Replace new document in an index',
        params => $params,
        returns => 'SuccessResponse',
        };
}
# @return SuccessResponse
#
sub replace {
    my ($self, %args) = @_;

    # verify the required parameter 'insert_document_request' is set
    unless (exists $args{'insert_document_request'}) {
      croak("Missing the required parameter 'insert_document_request' when calling replace");
    }

    # parse inputs
    my $_resource_path = '/json/replace';

    my $_method = 'POST';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept('application/json');
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type('application/json');

    my $_body_data;
    # body params
    if ( exists $args{'insert_document_request'}) {
        $_body_data = $args{'insert_document_request'};
    }

    # authentication setting, if any
    my $auth_settings = [qw()];

    # make the API Call
    my $response = $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    if (!$response) {
        return;
    }
    my $_response_object = $self->{api_client}->deserialize('SuccessResponse', $response);
    return $_response_object;
}

#
# update
#
# Update a document in an index
# 
# @param UpdateDocumentRequest $update_document_request  (required)
{
    my $params = {
    'update_document_request' => {
        data_type => 'UpdateDocumentRequest',
        description => '',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'update' } = { 
        summary => 'Update a document in an index',
        params => $params,
        returns => 'SuccessResponse',
        };
}
# @return SuccessResponse
#
sub update {
    my ($self, %args) = @_;

    # verify the required parameter 'update_document_request' is set
    unless (exists $args{'update_document_request'}) {
      croak("Missing the required parameter 'update_document_request' when calling update");
    }

    # parse inputs
    my $_resource_path = '/json/update';

    my $_method = 'POST';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept('application/json');
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type('application/json');

    my $_body_data;
    # body params
    if ( exists $args{'update_document_request'}) {
        $_body_data = $args{'update_document_request'};
    }

    # authentication setting, if any
    my $auth_settings = [qw()];

    # make the API Call
    my $response = $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    if (!$response) {
        return;
    }
    my $_response_object = $self->{api_client}->deserialize('SuccessResponse', $response);
    return $_response_object;
}

1;
