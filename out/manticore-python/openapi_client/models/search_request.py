# coding: utf-8

"""
    Manticore Search API

    This is the API for Manticore Search HTTP protocol   # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Contact: adrian.nuta@manticoresearch.com
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class SearchRequest(object):
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
        'index': 'str',
        'query': 'object',
        'limit': 'int',
        'offset': 'int',
        'max_matches': 'int',
        'sort': 'list[OneOfstringobject]',
        'script_fields': 'object',
        'highlight': 'object',
        'source': 'OneOfstringobject',
        'profile': 'bool'
    }

    attribute_map = {
        'index': 'index',
        'query': 'query',
        'limit': 'limit',
        'offset': 'offset',
        'max_matches': 'max_matches',
        'sort': 'sort',
        'script_fields': 'script_fields',
        'highlight': 'highlight',
        'source': '_source',
        'profile': 'profile'
    }

    def __init__(self, index=None, query=None, limit=None, offset=None, max_matches=None, sort=None, script_fields=None, highlight=None, source=None, profile=None, local_vars_configuration=None):  # noqa: E501
        """SearchRequest - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._index = None
        self._query = None
        self._limit = None
        self._offset = None
        self._max_matches = None
        self._sort = None
        self._script_fields = None
        self._highlight = None
        self._source = None
        self._profile = None
        self.discriminator = None

        self.index = index
        self.query = query
        if limit is not None:
            self.limit = limit
        if offset is not None:
            self.offset = offset
        if max_matches is not None:
            self.max_matches = max_matches
        if sort is not None:
            self.sort = sort
        if script_fields is not None:
            self.script_fields = script_fields
        if highlight is not None:
            self.highlight = highlight
        if source is not None:
            self.source = source
        if profile is not None:
            self.profile = profile

    @property
    def index(self):
        """Gets the index of this SearchRequest.  # noqa: E501


        :return: The index of this SearchRequest.  # noqa: E501
        :rtype: str
        """
        return self._index

    @index.setter
    def index(self, index):
        """Sets the index of this SearchRequest.


        :param index: The index of this SearchRequest.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and index is None:  # noqa: E501
            raise ValueError("Invalid value for `index`, must not be `None`")  # noqa: E501

        self._index = index

    @property
    def query(self):
        """Gets the query of this SearchRequest.  # noqa: E501


        :return: The query of this SearchRequest.  # noqa: E501
        :rtype: object
        """
        return self._query

    @query.setter
    def query(self, query):
        """Sets the query of this SearchRequest.


        :param query: The query of this SearchRequest.  # noqa: E501
        :type: object
        """
        if self.local_vars_configuration.client_side_validation and query is None:  # noqa: E501
            raise ValueError("Invalid value for `query`, must not be `None`")  # noqa: E501

        self._query = query

    @property
    def limit(self):
        """Gets the limit of this SearchRequest.  # noqa: E501


        :return: The limit of this SearchRequest.  # noqa: E501
        :rtype: int
        """
        return self._limit

    @limit.setter
    def limit(self, limit):
        """Sets the limit of this SearchRequest.


        :param limit: The limit of this SearchRequest.  # noqa: E501
        :type: int
        """
        if (self.local_vars_configuration.client_side_validation and
                limit is not None and limit < 0):  # noqa: E501
            raise ValueError("Invalid value for `limit`, must be a value greater than or equal to `0`")  # noqa: E501

        self._limit = limit

    @property
    def offset(self):
        """Gets the offset of this SearchRequest.  # noqa: E501


        :return: The offset of this SearchRequest.  # noqa: E501
        :rtype: int
        """
        return self._offset

    @offset.setter
    def offset(self, offset):
        """Sets the offset of this SearchRequest.


        :param offset: The offset of this SearchRequest.  # noqa: E501
        :type: int
        """
        if (self.local_vars_configuration.client_side_validation and
                offset is not None and offset < 0):  # noqa: E501
            raise ValueError("Invalid value for `offset`, must be a value greater than or equal to `0`")  # noqa: E501

        self._offset = offset

    @property
    def max_matches(self):
        """Gets the max_matches of this SearchRequest.  # noqa: E501


        :return: The max_matches of this SearchRequest.  # noqa: E501
        :rtype: int
        """
        return self._max_matches

    @max_matches.setter
    def max_matches(self, max_matches):
        """Sets the max_matches of this SearchRequest.


        :param max_matches: The max_matches of this SearchRequest.  # noqa: E501
        :type: int
        """
        if (self.local_vars_configuration.client_side_validation and
                max_matches is not None and max_matches < 0):  # noqa: E501
            raise ValueError("Invalid value for `max_matches`, must be a value greater than or equal to `0`")  # noqa: E501

        self._max_matches = max_matches

    @property
    def sort(self):
        """Gets the sort of this SearchRequest.  # noqa: E501


        :return: The sort of this SearchRequest.  # noqa: E501
        :rtype: list[OneOfstringobject]
        """
        return self._sort

    @sort.setter
    def sort(self, sort):
        """Sets the sort of this SearchRequest.


        :param sort: The sort of this SearchRequest.  # noqa: E501
        :type: list[OneOfstringobject]
        """

        self._sort = sort

    @property
    def script_fields(self):
        """Gets the script_fields of this SearchRequest.  # noqa: E501


        :return: The script_fields of this SearchRequest.  # noqa: E501
        :rtype: object
        """
        return self._script_fields

    @script_fields.setter
    def script_fields(self, script_fields):
        """Sets the script_fields of this SearchRequest.


        :param script_fields: The script_fields of this SearchRequest.  # noqa: E501
        :type: object
        """

        self._script_fields = script_fields

    @property
    def highlight(self):
        """Gets the highlight of this SearchRequest.  # noqa: E501


        :return: The highlight of this SearchRequest.  # noqa: E501
        :rtype: object
        """
        return self._highlight

    @highlight.setter
    def highlight(self, highlight):
        """Sets the highlight of this SearchRequest.


        :param highlight: The highlight of this SearchRequest.  # noqa: E501
        :type: object
        """

        self._highlight = highlight

    @property
    def source(self):
        """Gets the source of this SearchRequest.  # noqa: E501


        :return: The source of this SearchRequest.  # noqa: E501
        :rtype: OneOfstringobject
        """
        return self._source

    @source.setter
    def source(self, source):
        """Sets the source of this SearchRequest.


        :param source: The source of this SearchRequest.  # noqa: E501
        :type: OneOfstringobject
        """

        self._source = source

    @property
    def profile(self):
        """Gets the profile of this SearchRequest.  # noqa: E501


        :return: The profile of this SearchRequest.  # noqa: E501
        :rtype: bool
        """
        return self._profile

    @profile.setter
    def profile(self, profile):
        """Sets the profile of this SearchRequest.


        :param profile: The profile of this SearchRequest.  # noqa: E501
        :type: bool
        """

        self._profile = profile

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
        if not isinstance(other, SearchRequest):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, SearchRequest):
            return True

        return self.to_dict() != other.to_dict()
