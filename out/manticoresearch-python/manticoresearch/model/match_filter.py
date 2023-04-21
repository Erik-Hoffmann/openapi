# coding: utf-8

# Manticore Search Client
# Copyright (c) 2020-2021, Manticore Software LTD (https://manticoresearch.com)
# 
# All rights reserved
#



import pprint
import re  # noqa: F401

import six

from manticoresearch.configuration import Configuration

class MatchFilter(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'query_string': 'str',
        'query_fields': 'str'
    }

    attribute_map = {
        'query_string': 'query_string',
        'query_fields': 'query_fields'
    }

    def __init__(self, query_string="", query_fields="*", local_vars_configuration=None):  # noqa: E501
        """MatchFilter - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._query_string = None
        self._query_fields = None
        self.discriminator = None

        self.query_string = query_string
        self.query_fields = query_fields

    @property
    def query_string(self):
        """Gets the query_string of this MatchFilter.  # noqa: E501


        :return: The query_string of this MatchFilter.  # noqa: E501
        :rtype: str
        """
        return self._query_string
    @query_string.setter
    def query_string(self, query_string):
        """Sets the query_string of this MatchFilter.


        :param query_string: The query_string of this MatchFilter.  # noqa: E501
        :type query_string: str
        """
        if self.local_vars_configuration.client_side_validation and query_string is None:  # noqa: E501
            raise ValueError("Invalid value for `query_string`, must not be `None`")  # noqa: E501

        self._query_string = query_string
        

    @property
    def query_fields(self):
        """Gets the query_fields of this MatchFilter.  # noqa: E501


        :return: The query_fields of this MatchFilter.  # noqa: E501
        :rtype: str
        """
        return self._query_fields
    @query_fields.setter
    def query_fields(self, query_fields):
        """Sets the query_fields of this MatchFilter.


        :param query_fields: The query_fields of this MatchFilter.  # noqa: E501
        :type query_fields: str
        """
        if self.local_vars_configuration.client_side_validation and query_fields is None:  # noqa: E501
            raise ValueError("Invalid value for `query_fields`, must not be `None`")  # noqa: E501

        self._query_fields = query_fields
        


    def to_dict(self):
        """Returns the model properties as a dict"""
        result = { 'match': {self._query_fields: self._query_string} }




        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, MatchFilter):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, MatchFilter):
            return True

        return self.to_dict() != other.to_dict()