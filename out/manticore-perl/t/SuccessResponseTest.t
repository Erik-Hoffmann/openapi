=begin comment

Manticore Search API

This is the API for Manticore Search HTTP protocol 

The version of the OpenAPI document: 1.0.0
Contact: adrian.nuta@manticoresearch.com
Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by the OpenAPI Generator
# Please update the test cases below to test the model.
# Ref: https://openapi-generator.tech
#
use Test::More tests => 2;
use Test::Exception;

use lib 'lib';
use strict;
use warnings;


use_ok('WWW::OpenAPIClient::Object::SuccessResponse');

my $instance = WWW::OpenAPIClient::Object::SuccessResponse->new();

isa_ok($instance, 'WWW::OpenAPIClient::Object::SuccessResponse');

