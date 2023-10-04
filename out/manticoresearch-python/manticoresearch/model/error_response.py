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

class ErrorResponse(object):
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
        'error': '{str: (bool, date, datetime, dict, float, int, list, str, none_type)}',
        'status': 'int'
    }

    attribute_map = {
        'error': 'error',
        'status': 'status'
    }

    def __init__(self, error=None, status=None, local_vars_configuration=None):  # noqa: E501
        """ErrorResponse - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._error = None
        self._status = None
        self.discriminator = None

        self.error = error
        self.status = status

    @property
    def error(self):
        """Gets the error of this ErrorResponse.  # noqa: E501


        :return: The error of this ErrorResponse.  # noqa: E501
        :rtype: {str: (bool, date, datetime, dict, float, int, list, str, none_type)}
        """
        return self._error
    @error.setter
    def error(self, error):
        """Sets the error of this ErrorResponse.


        :param error: The error of this ErrorResponse.  # noqa: E501
        :type error: {str: (bool, date, datetime, dict, float, int, list, str, none_type)}
        """
        if self.local_vars_configuration.client_side_validation and error is None:  # noqa: E501
            raise ValueError("Invalid value for `error`, must not be `None`")  # noqa: E501

        self._error = error
        

    @property
    def status(self):
        """Gets the status of this ErrorResponse.  # noqa: E501


        :return: The status of this ErrorResponse.  # noqa: E501
        :rtype: int
        """
        return self._status
    @status.setter
    def status(self, status):
        """Sets the status of this ErrorResponse.


        :param status: The status of this ErrorResponse.  # noqa: E501
        :type status: int
        """
        if self.local_vars_configuration.client_side_validation and status is None:  # noqa: E501
            raise ValueError("Invalid value for `status`, must not be `None`")  # noqa: E501

        self._status = status
        


    def to_dict(self):
        """Returns the model properties as a dict"""

        result = {}		
        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value



        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, ErrorResponse):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, ErrorResponse):
            return True

        return self.to_dict() != other.to_dict()
