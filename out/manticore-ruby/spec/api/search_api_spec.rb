=begin
#Manticore Search API

#This is the API for Manticore Search HTTP protocol 

The version of the OpenAPI document: 1.0.0
Contact: info@manticoresearch.com
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.0.0-SNAPSHOT

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::SearchApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'SearchApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::SearchApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of SearchApi' do
    it 'should create an instance of SearchApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::SearchApi)
    end
  end

  # unit tests for percolate
  # Perform reverse search on a percolate index
  # @param index Name of the percolate index
  # @param percolate_request 
  # @param [Hash] opts the optional parameters
  # @return [SearchResponse]
  describe 'percolate test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for search
  # Performs a search
  # @param search_request 
  # @param [Hash] opts the optional parameters
  # @return [SearchResponse]
  describe 'search test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end