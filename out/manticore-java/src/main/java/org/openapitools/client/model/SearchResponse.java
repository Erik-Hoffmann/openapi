/*
 * Manticore Search API
 * This is the API for Manticore Search HTTP protocol 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: adrian.nuta@manticoresearch.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import org.openapitools.client.model.SearchResponseHits;

/**
 * SearchResponse
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2020-05-21T08:55:33.223Z[GMT]")
public class SearchResponse {
  public static final String SERIALIZED_NAME_TOOK = "took";
  @SerializedName(SERIALIZED_NAME_TOOK)
  private Integer took;

  public static final String SERIALIZED_NAME_TIMED_OUT = "timed_out";
  @SerializedName(SERIALIZED_NAME_TIMED_OUT)
  private Boolean timedOut;

  public static final String SERIALIZED_NAME_HITS = "hits";
  @SerializedName(SERIALIZED_NAME_HITS)
  private SearchResponseHits hits;

  public static final String SERIALIZED_NAME_PROFILE = "profile";
  @SerializedName(SERIALIZED_NAME_PROFILE)
  private Object profile;


  public SearchResponse took(Integer took) {
    
    this.took = took;
    return this;
  }

   /**
   * Get took
   * @return took
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getTook() {
    return took;
  }


  public void setTook(Integer took) {
    this.took = took;
  }


  public SearchResponse timedOut(Boolean timedOut) {
    
    this.timedOut = timedOut;
    return this;
  }

   /**
   * Get timedOut
   * @return timedOut
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getTimedOut() {
    return timedOut;
  }


  public void setTimedOut(Boolean timedOut) {
    this.timedOut = timedOut;
  }


  public SearchResponse hits(SearchResponseHits hits) {
    
    this.hits = hits;
    return this;
  }

   /**
   * Get hits
   * @return hits
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public SearchResponseHits getHits() {
    return hits;
  }


  public void setHits(SearchResponseHits hits) {
    this.hits = hits;
  }


  public SearchResponse profile(Object profile) {
    
    this.profile = profile;
    return this;
  }

   /**
   * Get profile
   * @return profile
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Object getProfile() {
    return profile;
  }


  public void setProfile(Object profile) {
    this.profile = profile;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SearchResponse searchResponse = (SearchResponse) o;
    return Objects.equals(this.took, searchResponse.took) &&
        Objects.equals(this.timedOut, searchResponse.timedOut) &&
        Objects.equals(this.hits, searchResponse.hits) &&
        Objects.equals(this.profile, searchResponse.profile);
  }

  @Override
  public int hashCode() {
    return Objects.hash(took, timedOut, hits, profile);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SearchResponse {\n");
    sb.append("    took: ").append(toIndentedString(took)).append("\n");
    sb.append("    timedOut: ").append(toIndentedString(timedOut)).append("\n");
    sb.append("    hits: ").append(toIndentedString(hits)).append("\n");
    sb.append("    profile: ").append(toIndentedString(profile)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

