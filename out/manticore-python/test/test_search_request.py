# coding: utf-8

"""
    Manticore Search API

    This is the API for Manticore Search HTTP protocol   # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Contact: adrian.nuta@manticoresearch.com
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest
import datetime

import openapi_client
from openapi_client.models.search_request import SearchRequest  # noqa: E501
from openapi_client.rest import ApiException

class TestSearchRequest(unittest.TestCase):
    """SearchRequest unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test SearchRequest
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = openapi_client.models.search_request.SearchRequest()  # noqa: E501
        if include_optional :
            return SearchRequest(
                index = '0', 
                query = None, 
                limit = 0, 
                offset = 0, 
                max_matches = 0, 
                sort = [
                    null
                    ], 
                script_fields = None, 
                highlight = None, 
                source = null, 
                profile = True
            )
        else :
            return SearchRequest(
                index = '0',
                query = None,
        )

    def testSearchRequest(self):
        """Test SearchRequest"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()
