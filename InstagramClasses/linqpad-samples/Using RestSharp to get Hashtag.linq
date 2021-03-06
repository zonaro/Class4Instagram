<Query Kind="Statements">
  <NuGetReference>RestSharp</NuGetReference>
  <Namespace>InstagramData</Namespace>
  <Namespace>LINQPad</Namespace>
  <Namespace>RestSharp</Namespace>
  <Namespace>RestSharp.Authenticators</Namespace>
  <Namespace>RestSharp.Authenticators.OAuth</Namespace>
  <Namespace>RestSharp.Deserializers</Namespace>
  <Namespace>RestSharp.Extensions</Namespace>
  <Namespace>RestSharp.Serialization</Namespace>
  <Namespace>RestSharp.Serialization.Json</Namespace>
  <Namespace>RestSharp.Serialization.Xml</Namespace>
  <Namespace>RestSharp.Serializers</Namespace>
  <Namespace>RestSharp.Serializers.Newtonsoft.Json</Namespace>
  <Namespace>RestSharp.Validation</Namespace>
  <IncludeLinqToSql>true</IncludeLinqToSql>
  <IncludeAspNet>true</IncludeAspNet>
</Query>


var client = new RestSharp.RestClient("https://www.instagram.com/");

var hashtagRequest = new RestSharp.RestRequest("/explore/tags/instagram/", Method.GET); // username

hashtagRequest.AddQueryParameter("__a", "1"); //add the parameter to force JSON response


var response = client.Execute<InstagramData.InstagramData>(hashtagRequest); //get the response
 
response.Data.graphql.hashtag
.Dump("Hashtag"); //dump response to LINQPad

 
