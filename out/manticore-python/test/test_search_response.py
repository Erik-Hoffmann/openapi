# coding: utf-8

"""
    Manticore Search API

    This is the API for Manticore Search HTTP protocol   # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Contact: info@manticoresearch.com
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest
import datetime

import openapi_client
from openapi_client.models.search_response import SearchResponse  # noqa: E501
from openapi_client.rest import ApiException

class TestSearchResponse(unittest.TestCase):
    """SearchResponse unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test SearchResponse
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = openapi_client.models.search_response.SearchResponse()  # noqa: E501
        if include_optional :
            return SearchResponse(
                took = 56, 
                timed_out = True, 
                hits = {"total":2,"hits":[{"_id":1,"_score":1,"_source":{"gid":11}},{"_id":2,"_score":1,"_source":{"gid":20}}]}, 
                profile = None
            )
        else :
            return SearchResponse(
        )

    def testSearchResponse(self):
        """Test SearchResponse"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()