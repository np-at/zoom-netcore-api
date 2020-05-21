using System;
using System.Globalization;
using System.Runtime.Serialization;
using AndcultureCode.ZoomClient.Extensions;
using AndcultureCode.ZoomClient.Interfaces;
using AndcultureCode.ZoomClient.Models;
using AndcultureCode.ZoomClient.Models.Meetings;
using AndcultureCode.ZoomClient.Models.Recordings;
using RestSharp;

namespace AndcultureCode.ZoomClient
{
    public class ZoomRecordingsClient : IZoomRecordingsClient
    {
        #region Constants

        private const string GET_LIST_USER_RECORDINGS = "users/{userId}/recordings";
        
        #endregion
        
        
        #region Properties

        private ZoomClientOptions Options { get; set; }

        private RestClient WebClient { get; set; }
        
        #endregion
        
        #region Constructor
        
        public ZoomRecordingsClient(ZoomClientOptions options, RestClient webClient)
        {
            Options = options;
            WebClient = webClient;
            
        }
        
        #endregion
   
        #region IZoomRecordingsClient Implementation

        public ListRecordings GetUserRecordings(string userId,
            DateTime @from, DateTime to, string trashType = "meeting_recording", int pageSize = 30,
            int pageNumber = 1, bool showTrash = false)
        {
            if (pageSize > 300)
            {
                throw new Exception("GetMeetings page size max 300");
            }

            var request = BuildRequestAuthorization(GET_LIST_USER_RECORDINGS, Method.GET);
            request.AddParameter("userId", value: userId, type: ParameterType.UrlSegment);
            request.AddParameter("trash", value: showTrash, type: ParameterType.QueryString);
            request.AddParameter("page_size", value: pageSize, type: ParameterType.QueryString);
            request.AddParameter("page_number", value: pageNumber, type: ParameterType.QueryString);
            request.AddParameter("from", from.ToString(format: "yyyy-M-d"), ParameterType.QueryString);
            request.AddParameter("to", to.ToString(format: "yyyy-M-d"), ParameterType.QueryString);
            request.AddParameter("trash_type", trashType, ParameterType.QueryString);

            var response = WebClient.Execute<ListRecordings>(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return response.Data;
            }

            if (!string.IsNullOrWhiteSpace(response.ErrorMessage))
            {
                throw new Exception(response.ErrorMessage);
            }

            if (!string.IsNullOrWhiteSpace(response.StatusDescription) && !string.IsNullOrWhiteSpace(response.Content))
            {
                throw new Exception($"{response.StatusDescription} || {response.Content}");
            }

            if (!string.IsNullOrWhiteSpace(response.Content))
            {
                throw new Exception($"{response.StatusCode} || {response.Content}");
            }

            return null;
        }

        public ListRecordings GetAccountRecordings(string accountId, int pageSize = 30, int pageNumber = 1)
        {
            throw new NotImplementedException();
        }

        public RecordingFileList GetRecording(string meetingId)
        {
            throw new NotImplementedException();
        }
        
        #endregion

        #region PrivateMethods

        RestRequest BuildRequestAuthorization(string resource, Method method)
        {
            return WebClient.BuildRequestAuthorization(Options, resource, method);
        }

        #endregion
    }
}